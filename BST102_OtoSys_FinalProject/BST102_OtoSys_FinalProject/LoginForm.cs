using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BST102_OtoSys_FinalProject
{
    public partial class LoginForm : Form
    {
        // Sabit kullanıcı adı-şifre listesi
        private Dictionary<string, string> kullanicilar = new Dictionary<string, string>
        {
            { "admin", "1234" },
            { "user", "5678" },
            { "test", "0000" }
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (kullanicilar.ContainsKey(kullaniciAdi) && kullanicilar[kullaniciAdi] == sifre)
            {
                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide(); // Giriş formunu gizle
            }
            else
            {
                lblUyari.Visible = true;
                txtSifre.Clear();
                txtSifre.Focus();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
