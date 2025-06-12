using System;

namespace BST102_OtoSys_FinalProject
{
    public class Arac
    {
        public int AracId { get; set; }

        // Null atanamaz uyarılarını önlemek için varsayılan boş değerler atandı
        public string Tur { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime UretimBaslangicTarihi { get; set; }
        public DateTime? UretimBitisTarihi { get; set; }
        public decimal MaliyetTutari { get; set; }
        public int SatisDurumu { get; set; } // 0: Satıldı, 1: Satılacak
        public int UretimAdedi { get; set; }
        public string UretimSeriNo { get; set; } = string.Empty; // Veritabanında computed, boş bırakılmamalı
    }

    public enum SatisDurumu
    {
        Satildi = 0,
        Satilacak = 1
    }
}
