using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST102_OtoSys_FinalProject
{
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
}
