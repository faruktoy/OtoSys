using System;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class Form2 : Form
    {
        public string UretimSeriNo { get; set; }
        public string Tur { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int UretimAdedi { get; set; }
        public decimal Maliyet { get; set; }
        public decimal SatisTutari { get; set; }
        public bool SatildiMi { get; set; }

        public Form2(Arac secilen)
        {
            InitializeComponent();
            UretimSeriNo = secilen.UretimSeriNo;
            Marka = secilen.Marka;
            Model = secilen.Model;
            UretimAdedi = secilen.UretimAdedi;
            Maliyet = secilen.MaliyetTutari;
            Tur = secilen.Tur;
            SatildiMi = secilen.SatisDurumu == 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbTur2.Items.AddRange(new string[] {
            "SUV", "Sedan", "Hatchback", "Pick-up", "Coupe",
            "Cabrio", "Minivan", "MPV", "Station Wagon", "Panelvan", "Kamyonet"
            });
            cmbTur2.SelectedItem = Tur;
            txtİD2.Text = UretimSeriNo.ToString();
            txtMarka2.Text = Marka;
            txtModel2.Text = Model;
            numUretimAdedi2.Value = UretimAdedi;
            txtMaliyet2.Text = Maliyet.ToString();
            chkSatildimi2.Checked = SatildiMi;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            string yeniMarka = txtMarka2.Text;
            string yeniModel = txtModel2.Text;
            int yeniUretimAdedi = (int)numUretimAdedi2.Value;
            decimal yeniMaliyet = Convert.ToDecimal(txtMaliyet2.Text);
            string yeniTur = cmbTur2.SelectedItem?.ToString() ?? "";
            bool yeniSatildiMi = chkSatildimi2.Checked;

            if (this.Owner is Form1 mainForm)
            {
                mainForm.UpdateArac(UretimSeriNo, yeniTur, yeniMarka, yeniModel, yeniUretimAdedi, yeniMaliyet, yeniSatildiMi);
                MessageBox.Show("Araç bilgileri başarıyla güncellendi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı.");
            }
        }

        private void btnIptal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
