using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace BST102_OtoSys_FinalProject
{
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

        /// <summary>
        /// Veritabanındaki tüm araç kayıtlarını bir DataTable olarak getirir.
        /// Bu metot, DataGridView'i doldurmak için idealdir.
        /// </summary>
        /// <returns>Araçları içeren bir DataTable.</returns>
        public DataTable AraclariGetir()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SELECT * sorgusu yeni eklenen UretimAdedi kolonunu otomatik olarak alacaktır.
                string query = "SELECT * FROM Arac ORDER BY AracId DESC"; // Son eklenenler üstte görünsün diye sıralama eklendi.
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable); // Gelen verileri DataTable'a doldur.
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                    }
                }
            }
            return dataTable;
        }

        // TODO - 3. KİŞİNİN SORUMLULUĞU: Proje ilerledikçe buraya 'AracGuncelle' ve 'AracSil' metotları eklenecek.
        // public bool AracGuncelle(Arac guncellenecekArac) { ... }
        // public bool AracSil(int aracId) { ... }
    }
}
