// GEREKLÝ USING ALANI
using OtoSys;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class Form1 : Form
    {
        VeritabaniIslemleri db = new VeritabaniIslemleri(); // Veritabaný iþlemleri sýnýfý

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Arac yeniArac = new Arac()
                {
                    Tur = cmbTur.SelectedItem?.ToString() ?? "",
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    UretimBaslangicTarihi = dtpBaslangic.Value,
                    UretimBitisTarihi = dtpBitis.Checked ? dtpBitis.Value : null,
                    MaliyetTutari = Convert.ToDecimal(txtMaliyet.Text),
                    SatisDurumu = chkSatildimi.Checked ? 0 : 1, // 0 = Satýldý, 1 = Satýlacak
                    UretimAdedi = (int)numUretimAdedi.Value
                };

                if (db.AracEkle(yeniArac))
                {
                    MessageBox.Show("Araç baþarýyla eklendi.");
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Araç eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["AracId"].Value);
                DialogResult sonuc = MessageBox.Show("Bu aracý silmek istediðinize emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    if (db.AracSil(secilenId))
                    {
                        MessageBox.Show("Araç baþarýyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silme iþlemi baþarýsýz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek aracý seçiniz.");
            }
        }

        private void Temizle()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtMaliyet.Clear();
            cmbTur.SelectedIndex = -1;
            numUretimAdedi.Value = 0;
            chkSatildimi.Checked = false;
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            dtpBitis.Checked = false;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvAraclar.SelectedRows[0].Cells["AracId"].Value);
                Form2 guncelleForm = new Form2(id);
                guncelleForm.Owner = this;
                guncelleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir araç seçiniz.");
            }
        }
    }
}
