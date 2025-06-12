using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace OtoSys
{
    // Araç bilgilerini taşıyan temel sınıf /
    public class Arac
    {
        public int AracId { get; set; }
        public string Tur { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime UretimBaslangicTarihi { get; set; }
        public DateTime? UretimBitisTarihi { get; set; }
        public decimal MaliyetTutari { get; set; }
        public int SatisDurumu { get; set; }
        public int UretimAdedi { get; set; }
        public string UretimSeriNo { get; set; } = string.Empty;
    }

    // Veritabanı işlemlerini yöneten sınıf
    public class VeritabaniIslemleri
    {
        // Bağlantı bilgisi App.config dosyasından alınır
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["OtoSysConn"].ConnectionString;

        // Yeni araç ekleme metodu
        public bool AracEkle(Arac yeniArac)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Arac 
                                 (Tur, Marka, Model, UretimBaslangicTarihi, UretimBitisTarihi, MaliyetTutari, SatisDurumu, UretimAdedi)
                                 VALUES (@Tur, @Marka, @Model, @UBT, @UBiT, @Maliyet, @Satis, @Adet)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tur", yeniArac.Tur);
                    command.Parameters.AddWithValue("@Marka", yeniArac.Marka);
                    command.Parameters.AddWithValue("@Model", yeniArac.Model);
                    command.Parameters.AddWithValue("@UBT", yeniArac.UretimBaslangicTarihi);
                    command.Parameters.AddWithValue("@UBiT", (object?)yeniArac.UretimBitisTarihi ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Maliyet", yeniArac.MaliyetTutari);
                    command.Parameters.AddWithValue("@Satis", yeniArac.SatisDurumu);
                    command.Parameters.AddWithValue("@Adet", yeniArac.UretimAdedi);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Mevcut bir aracı güncelleme metodu
        public bool AracGuncelle(Arac arac)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Arac SET 
                                    Tur = @Tur,
                                    Marka = @Marka,
                                    Model = @Model,
                                    UretimBaslangicTarihi = @UBT,
                                    UretimBitisTarihi = @UBiT,
                                    MaliyetTutari = @Maliyet,
                                    SatisDurumu = @Satis,
                                    UretimAdedi = @Adet
                                 WHERE AracId = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tur", arac.Tur);
                    command.Parameters.AddWithValue("@Marka", arac.Marka);
                    command.Parameters.AddWithValue("@Model", arac.Model);
                    command.Parameters.AddWithValue("@UBT", arac.UretimBaslangicTarihi);
                    command.Parameters.AddWithValue("@UBiT", (object?)arac.UretimBitisTarihi ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Maliyet", arac.MaliyetTutari);
                    command.Parameters.AddWithValue("@Satis", arac.SatisDurumu);
                    command.Parameters.AddWithValue("@Adet", arac.UretimAdedi);
                    command.Parameters.AddWithValue("@Id", arac.AracId);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Araç silme işlemi
        public bool AracSil(int aracId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Arac WHERE AracId = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", aracId);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        // Tüm araçları listeleme işlemi
        public List<Arac> AraclariGetir()
        {
            List<Arac> liste = new List<Arac>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Arac";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var arac = new Arac
                            {
                                AracId = Convert.ToInt32(reader["AracId"]),
                                Tur = reader["Tur"].ToString(),
                                Marka = reader["Marka"].ToString(),
                                Model = reader["Model"].ToString(),
                                UretimBaslangicTarihi = Convert.ToDateTime(reader["UretimBaslangicTarihi"]),
                                UretimBitisTarihi = reader["UretimBitisTarihi"] == DBNull.Value ? null : Convert.ToDateTime(reader["UretimBitisTarihi"]),
                                MaliyetTutari = Convert.ToDecimal(reader["MaliyetTutari"]),
                                SatisDurumu = Convert.ToInt32(reader["SatisDurumu"]),
                                UretimAdedi = Convert.ToInt32(reader["UretimAdedi"]),
                                UretimSeriNo = reader["UretimSeriNo"].ToString()
                            };
                            liste.Add(arac);
                        }
                    }
                }
            }

            return liste;
        }
    }
}
