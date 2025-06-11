// Form2.cs
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde, public property'lere aktarılan verileri kontrollere doldurun
            // Tasarımınıza göre bu kontrollerin isimlerini doğru kullandığınızdan emin olun

            txtİD2.Text = AracId.ToString(); // AracId'yi göster
            txtMarka2.Text = Marka; // txtMarka2 olarak değiştirildi
            txtModel2.Text = Model; // txtModel2 olarak değiştirildi
            numUretimAdedi2.Value = (decimal)UretimAdedi; // numUretimAdedi2 olarak değiştirildi
            txtMaliyet2.Text = Maliyet.ToString(); // txtMaliyet2 olarak değiştirildi
            txtSatisTutari2.Text = SatisTutari.ToString(); // txtSatisTutari2 olarak değiştirildi
            chkSatildimi2.Checked = SatildiMi; // CheckBox için .Checked kullanılır

            // AracId'nin düzenlenemez olmasını sağlayın
            txtİD2.ReadOnly = true;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            // Verileri Form2 kontrollerinden al
            // TextBox'lardan alınan değerleri uygun tiplere dönüştürmeyi unutmayın
            string yeniMarka = txtMarka2.Text;
            string yeniModel = txtModel2.Text;
            int yeniUretimAdedi = (int)numUretimAdedi2.Value;
            decimal yeniMaliyet = Convert.ToDecimal(txtMaliyet2.Text);
            decimal yeniSatisTutari = Convert.ToDecimal(txtSatisTutari2.Text);
            bool yeniSatildiMi = chkSatildimi2.Checked;

            // Form1'deki UpdateArac metodunu çağır
            Form1 mainForm = this.Owner as Form1;
            if (mainForm != null)
            {
                mainForm.UpdateArac(this.AracId, yeniMarka, yeniModel, yeniUretimAdedi, yeniMaliyet, yeniSatisTutari, yeniSatildiMi);
                MessageBox.Show("Araç bilgileri başarıyla güncellendi.");
                this.Close(); // Güncelleme işlemi bitince Form2'yi kapat
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı.");
            }
        }

        private void btnIptal2_Click(object sender, EventArgs e)
        {
            this.Close(); // İptal butonuna basıldığında Form2'yi kapat
        }


    }
}