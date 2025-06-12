// Form1.cs
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // DataGridView'i örnek verilerle doldur (test amaçlý)
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AracId", typeof(int));
            dt.Columns.Add("Marka", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("UretimAdedi", typeof(int));
            dt.Columns.Add("Maliyet", typeof(decimal));
            dt.Columns.Add("SatisTutari", typeof(decimal));
            dt.Columns.Add("SatildiMi", typeof(bool));

            dt.Rows.Add(1, "Toyota", "Corolla", 100, 150000.00m, 180000.00m, false);
            dt.Rows.Add(2, "Honda", "Civic", 80, 160000.00m, 190000.00m, true);
            dt.Rows.Add(3, "Ford", "Focus", 120, 140000.00m, 170000.00m, false);

            dgvAraclar.DataSource = dt;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (dgvAraclar.SelectedRows.Count > 0)
            {
                // Seçilen ilk satýrý al
                DataGridViewRow selectedRow = dgvAraclar.SelectedRows[0];

                // Form2'nin bir örneðini oluþtur
                Form2 form2 = new Form2();

                // Verileri Form2'deki public property'lere aktar
                form2.AracId = Convert.ToInt32(selectedRow.Cells["AracId"].Value);
                form2.Marka = selectedRow.Cells["Marka"].Value.ToString();
                form2.Model = selectedRow.Cells["Model"].Value.ToString();
                form2.UretimAdedi = Convert.ToInt32(selectedRow.Cells["UretimAdedi"].Value);
                form2.Maliyet = Convert.ToDecimal(selectedRow.Cells["Maliyet"].Value);
                form2.SatisTutari = Convert.ToDecimal(selectedRow.Cells["SatisTutari"].Value);
                form2.SatildiMi = Convert.ToBoolean(selectedRow.Cells["SatildiMi"].Value);

                // Form2'yi göster
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir araç seçin.");
            }
        }
    }
}