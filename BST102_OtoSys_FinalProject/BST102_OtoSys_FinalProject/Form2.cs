using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class Form2 : Form
    {
        // Form1'den gönderilecek araç verilerini tutacak public property'ler
        public int AracId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int UretimAdedi { get; set; }
        public decimal Maliyet { get; set; }
        public decimal SatisTutari { get; set; }
        public bool SatildiMi { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

    }
}
