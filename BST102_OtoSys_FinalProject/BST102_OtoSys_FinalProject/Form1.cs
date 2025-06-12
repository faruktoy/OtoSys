using BST102_OtoSys_FinalProject;
using System;
using System.Data;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class Form1 : Form
    {
        private VeritabaniIslemleri db;

        public Form1()
        {
            InitializeComponent();
            db = new VeritabaniIslemleri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTur.Items.Clear();
            cmbTur.Items.AddRange(new string[] {
            "SUV", "Sedan", "Hatchback", "Pick-up", "Coupe",
            "Cabrio", "Minivan", "MPV", "Station Wagon", "Panelvan", "Kamyonet"
            });
            cmbTur.SelectedIndex = 0;
            txtPart.Text = db.UretimSeriNoGetir();
            Listele();
            HesaplaOzetBilgiler();
        }

        private void Listele()
        {
            try
            {
                dgvAraclar.DataSource = db.AraclariGetir().Tables["Arac"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Arac yeniArac = new Arac()
            {
                Tur = cmbTur.Text,
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                UretimBaslangicTarihi = dtpBaslangic.Value,
                UretimBitisTarihi = dtpBitis.Checked ? dtpBitis.Value : (DateTime?)null,
                MaliyetTutari = Convert.ToDecimal(txtMaliyet.Text),
                SatisDurumu = chkSatildimi.Checked ? 0 : 1,
                UretimAdedi = (int)numUretimAdedi.Value,

            };

            bool sonuc = db.AracEkle(yeniArac);
            if (sonuc)
            {
                MessageBox.Show("Araç başarıyla eklendi.");
                Temizle();
                Listele();
                HesaplaOzetBilgiler();
            }
            else
            {
                MessageBox.Show("Ekleme sırasında hata oluştu.");
            }
        }

        private void Temizle()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtMaliyet.Value = 0;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            chkSatildimi.Checked = false;
            numUretimAdedi.Value = 0;
            txtPart.Text = db.UretimSeriNoGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["AracId"].Value);
                DialogResult result = MessageBox.Show("Bu aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    db.AracSil(secilenId);
                    Listele();
                    HesaplaOzetBilgiler();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir araç seçin.");
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                DataRowView rowView = dgvAraclar.SelectedRows[0].DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    Arac secilen = new Arac
                    {
                        UretimSeriNo = rowView["UretimSeriNo"].ToString(),
                        Tur = rowView["Tur"].ToString(),
                        Marka = rowView["Marka"].ToString(),
                        Model = rowView["Model"].ToString(),
                        UretimAdedi = Convert.ToInt32(rowView["UretimAdedi"]),
                        MaliyetTutari = Convert.ToDecimal(rowView["MaliyetTutari"]),
                        SatisDurumu = Convert.ToInt32(rowView["SatisDurumu"])
                    };

                    Form2 frm = new Form2(secilen);
                    frm.Owner = this;
                    frm.ShowDialog();
                    Listele();
                    HesaplaOzetBilgiler();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir araç seçin.");
            }
        }

        public void UpdateArac(string id, string yeniTur, string yeniMarka, string yeniModel, int yeniAdet, decimal yeniMaliyet, bool satildiMi)
        {
            Arac guncellenen = new Arac
            {
                UretimSeriNo = id,
                Tur = yeniTur,
                Marka = yeniMarka,
                Model = yeniModel,
                UretimAdedi = yeniAdet,
                MaliyetTutari = yeniMaliyet,
                SatisDurumu = satildiMi ? 0 : 1
            };

            db.AracGuncelle(guncellenen);
        }

        private void HesaplaOzetBilgiler()
        {
            DataTable araclar = db.AraclariGetir().Tables["Arac"];
            int toplamAdet = 0;
            decimal toplamMaliyet = 0;
            decimal toplamSatilanMaliyet = 0;

            foreach (DataRow row in araclar.Rows)
            {
                int adet = Convert.ToInt32(row["UretimAdedi"]);
                decimal maliyet = Convert.ToDecimal(row["MaliyetTutari"]);
                int satisDurumu = Convert.ToInt32(row["SatisDurumu"]);

                toplamAdet += adet;
                toplamMaliyet += maliyet * adet;

                if (satisDurumu == 0)
                {
                    toplamSatilanMaliyet += maliyet * adet;
                }
            }

            lblToplamUretim.Text = toplamAdet.ToString();
            lblToplamMaliyet.Text = toplamMaliyet.ToString("C2");
            lblSatilanMaliyet.Text = toplamSatilanMaliyet.ToString("C2");
        }

        private void lblToplamAdet_Click(object sender, EventArgs e)
        {
            // Boş bırakıldı
        }

        private void dgvAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
