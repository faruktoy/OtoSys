﻿using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace BST102_OtoSys_FinalProject
{
    public class VeritabaniIslemleri
    {
        //Server kısmını, kendi sql 'server name' değerinizle değiştirin. (Server=**;)
        private SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=OtoSysDB;Trusted_Connection=True;TrustServerCertificate=True");
        private SqlDataAdapter da;
        private DataSet ds;

        public DataSet AraclariGetir()
        {
            da = new SqlDataAdapter("SELECT * FROM Arac", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Arac");
            baglanti.Close();
            return ds;
        }
    

        public bool AracEkle(Arac yeniArac)
        {
            string query = @"INSERT INTO Arac (Tur, Marka, Model, UretimBaslangicTarihi, UretimBitisTarihi, MaliyetTutari, SatisDurumu, UretimAdedi)
                             VALUES (@Tur, @Marka, @Model, @UBT, @UBiT, @Maliyet, @Satis, @Adet)";

            using (SqlCommand komut = new SqlCommand(query, baglanti))
            {
                komut.Parameters.AddWithValue("@Tur", yeniArac.Tur);
                komut.Parameters.AddWithValue("@Marka", yeniArac.Marka);
                komut.Parameters.AddWithValue("@Model", yeniArac.Model);
                komut.Parameters.AddWithValue("@UBT", yeniArac.UretimBaslangicTarihi);
                komut.Parameters.AddWithValue("@UBiT", (object?)yeniArac.UretimBitisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@Maliyet", yeniArac.MaliyetTutari);
                komut.Parameters.AddWithValue("@Satis", yeniArac.SatisDurumu);
                komut.Parameters.AddWithValue("@Adet", yeniArac.UretimAdedi);

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                return sonuc > 0;
            }
        }

        public bool AracGuncelle(Arac arac)
        {
            string query = @"UPDATE Arac SET Tur = @Tur, Marka = @Marka, Model = @Model, UretimBaslangicTarihi = @UBT, UretimBitisTarihi = @UBiT, MaliyetTutari = @Maliyet, SatisDurumu = @Satis, UretimAdedi = @Adet WHERE AracId = @Id";

            using (SqlCommand komut = new SqlCommand(query, baglanti))
            {
                komut.Parameters.AddWithValue("@Tur", arac.Tur);
                komut.Parameters.AddWithValue("@Marka", arac.Marka);
                komut.Parameters.AddWithValue("@Model", arac.Model);
                komut.Parameters.AddWithValue("@UBT", arac.UretimBaslangicTarihi);
                komut.Parameters.AddWithValue("@UBiT", (object?)arac.UretimBitisTarihi ?? DBNull.Value);
                komut.Parameters.AddWithValue("@Maliyet", arac.MaliyetTutari);
                komut.Parameters.AddWithValue("@Satis", arac.SatisDurumu);
                komut.Parameters.AddWithValue("@Adet", arac.UretimAdedi);
                komut.Parameters.AddWithValue("@Id", arac.AracId);

                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();

                return sonuc > 0;
            }
        }

        public bool AracSil(int aracId)
        {
            string query = "DELETE FROM Arac WHERE AracId = @Id";

            using (SqlCommand komut = new SqlCommand(query, baglanti))
            {
                komut.Parameters.AddWithValue("@Id", aracId);
                baglanti.Open();
                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();
                return sonuc > 0;
            }
        }

        public string UretimSeriNoGetir()
        {
            const string prefix = "TGTRM2PRT";
            string query = "SELECT ISNULL(MAX(AracId), 998) + 2 FROM Arac";
            string seriNo = $"{prefix}00000";

            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, baglanti))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0]);
                    seriNo = $"{prefix}{id:D5}";
                }
            }

            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

            return seriNo;
        }
    }
}
