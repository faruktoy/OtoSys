using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient; // DEĞİŞİKLİK: Modern kütüphane kullanıldı.

// Projenizin ismine göre namespace'i düzenleyebilirsiniz.
namespace OtoSys
{
    /// <summary>
    /// Veritabanındaki 'Arac' tablosundaki bir satırı temsil eden sınıf.
    /// Bu sınıfı kullanmak, kod içerisinde veri taşımayı kolaylaştırır.
    /// </summary>
    public class Arac
    {
        public int AracId { get; set; }
        public string SaseNo { get; set; }
        public string Tur { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime UretimBaslangicTarihi { get; set; }
        public DateTime? UretimBitisTarihi { get; set; } // Null olabilir, bu yüzden '?' ekledik.
        public decimal MaliyetTutari { get; set; }
        public string SatisDurumu { get; set; } // "Satıldı" veya "Satılacak"
        public int UretimAdedi { get; set; }
    }

    /// <summary>
    /// Veritabanı ile ilgili tüm CRUD (Create, Read, Update, Delete)
    /// işlemlerini yöneten sınıf.
    /// </summary>
    public class VeritabaniIslemleri
    {
        // DEĞİŞİKLİK: Bağlantı bilgisi artık doğrudan App.config dosyasından okunuyor.
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["OtoSysConn"].ConnectionString;

        /// <summary>
        /// Veritabanına yeni bir araç kaydı ekler.
        /// </summary>
        /// <param name="yeniArac">Eklenecek araç bilgilerini içeren Arac nesnesi.</param>
        /// <returns>İşlem başarılıysa true, değilse false döner.</returns>
        public bool AracEkle(Arac yeniArac)
        {
            // using bloğu, bağlantının otomatik olarak kapatılmasını sağlar.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL komutumuzu parametreli olarak hazırlıyoruz. Bu, SQL Injection saldırılarını önler.
                // UretimAdedi kolonu da INSERT sorgusuna eklendi.
                string query = "INSERT INTO Arac (Tur, Marka, Model, UretimBaslangicTarihi, UretimBitisTarihi, MaliyetTutari, SatisDurumu, UretimAdedi) VALUES (@Tur, @Marka, @Model, @UretimBaslangicTarihi, @UretimBitisTarihi, @MaliyetTutari, @SatisDurumu, @UretimAdedi)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri Arac nesnesinden gelen değerlerle dolduruyoruz.
                    command.Parameters.AddWithValue("@Tur", yeniArac.Tur);
                    command.Parameters.AddWithValue("@Marka", yeniArac.Marka);
                    command.Parameters.AddWithValue("@Model", yeniArac.Model);
                    command.Parameters.AddWithValue("@UretimBaslangicTarihi", yeniArac.UretimBaslangicTarihi);

                    // UretimBitisTarihi null olabilir, bunu kontrol ediyoruz.
                    if (yeniArac.UretimBitisTarihi.HasValue)
                    {
                        command.Parameters.AddWithValue("@UretimBitisTarihi", yeniArac.UretimBitisTarihi.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@UretimBitisTarihi", DBNull.Value);
                    }

                    command.Parameters.AddWithValue("@MaliyetTutari", yeniArac.MaliyetTutari);
                    command.Parameters.AddWithValue("@SatisDurumu", yeniArac.SatisDurumu);
                    command.Parameters.AddWithValue("@UretimAdedi", yeniArac.UretimAdedi);


                    try
                    {
                        connection.Open();
                        int etkilenenSatirSayisi = command.ExecuteNonQuery(); // Komutu çalıştır.
                        return etkilenenSatirSayisi > 0; // Eğer en az bir satır eklendiyse true döner.
                    }
                    catch (Exception ex)
                    {
                        // Hata olursa konsola yazdır (daha sonra bir loglama mekanizmasına dönüştürülebilir).
                        Console.WriteLine("Hata: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public bool AracGuncelle(Arac arac)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Arac SET Tur = @Tur, Marka = @Marka, Model = @Model, UretimBaslangicTarihi = @UBT, UretimBitisTarihi = @UBiT, MaliyetTutari = @Maliyet, SatisDurumu = @Satis WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Tur", arac.Tur);
                    command.Parameters.AddWithValue("@Marka", arac.Marka);
                    command.Parameters.AddWithValue("@Model", arac.Model);
                    command.Parameters.AddWithValue("@UBT", arac.UretimBaslangicTarihi);
                    command.Parameters.AddWithValue("@UBiT", arac.UretimBitisTarihi);
                    command.Parameters.AddWithValue("@Maliyet", arac.MaliyetTutari);
                    command.Parameters.AddWithValue("@Satis", arac.SatisDurumu);
                    command.Parameters.AddWithValue("@Id", arac.AracId);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AracSil(int AracId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Arac WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", AracId);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<Arac> AraclariGetir()
        {
            List<Arac> araclar = new List<Arac>();
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
                            Arac a = new Arac
                            {
                                AracId = (int)reader["Id"],
                                Tur = reader["Tur"].ToString(),
                                Marka = reader["Marka"].ToString(),
                                Model = reader["Model"].ToString(),
                                UretimBaslangicTarihi = (DateTime)reader["UretimBaslangicTarihi"],
                                UretimBitisTarihi = (DateTime)reader["UretimBitisTarihi"],
                                MaliyetTutari = Convert.ToDecimal(reader["MaliyetTutari"]),
                                SatisDurumu = Convert.ToInt32(reader["SatisDurumu"])
                            };
                            araclar.Add(a);
                        }
                    }
                }
            }
            return araclar;
        }



    }
}
