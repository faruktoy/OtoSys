using System;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class Form2 : Form
    {
        // Özellikler
        public int AracId { get; set; }
        public string UretimSeriNo { get; set; }
        public string Tur { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int UretimAdedi { get; set; }
        public decimal Maliyet { get; set; }
        public bool SatildiMi { get; set; }
        public DateTime UretimBaslangicTarihi { get; set; }
        public DateTime? UretimBitisTarihi { get; set; }

        // Constructor
        public Form2(Arac secilen)
        {
            InitializeComponent();

            AracId = secilen.AracId;
            UretimSeriNo = secilen.UretimSeriNo;
            Tur = secilen.Tur;
            Marka = secilen.Marka;
            Model = secilen.Model;
            UretimAdedi = secilen.UretimAdedi;
            Maliyet = secilen.MaliyetTutari;
            SatildiMi = secilen.SatisDurumu == 0;
            UretimBaslangicTarihi = secilen.UretimBaslangicTarihi;
            UretimBitisTarihi = secilen.UretimBitisTarihi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbTur2.Items.AddRange(new string[]
            {
                "SUV", "Sedan", "Hatchback", "Pick-up", "Coupe",
                "Cabrio", "Minivan", "MPV", "Station Wagon", "Panelvan", "Kamyonet"
            });

            cmbTur2.SelectedItem = Tur;
            txtİD2.Text = UretimSeriNo;
            txtMarka2.Text = Marka;
            txtModel2.Text = Model;
            numUretimAdedi2.Value = UretimAdedi;
            txtMaliyet2.Text = Maliyet.ToString();

            dtpBaslangic2.Value = UretimBaslangicTarihi;

            if (UretimBitisTarihi.HasValue)
            {
                dtpBitis2.Value = UretimBitisTarihi.Value;
                dtpBitis2.Checked = true;
            }
            else
            {
                dtpBitis2.Checked = false;
            }

            chkSatildimi2.Checked = SatildiMi;
        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            try
            {
                string yeniTur = cmbTur2.SelectedItem?.ToString() ?? "";
                string yeniMarka = txtMarka2.Text;
                string yeniModel = txtModel2.Text;
                int yeniUretimAdedi = (int)numUretimAdedi2.Value;
                decimal yeniMaliyet = Convert.ToDecimal(txtMaliyet2.Text);
                DateTime ubt = dtpBaslangic2.Value;
                DateTime? ubit = dtpBitis2.Checked ? dtpBitis2.Value : (DateTime?)null;
                bool yeniSatildiMi = chkSatildimi2.Checked;

                if (this.Owner is Form1 mainForm)
                {
                    mainForm.UpdateArac(AracId, UretimSeriNo, yeniTur, yeniMarka, yeniModel, yeniUretimAdedi, yeniMaliyet, yeniSatildiMi, ubt, ubit);
                    MessageBox.Show("Araç bilgileri başarıyla güncellendi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ana form bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message);
            }
        }

        private void btnIptal2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
