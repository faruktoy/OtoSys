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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        // Buraya istediğiniz kullanıcı adını yazabilirsiniz.
        // Örneğin: "admin", "kullanici1", "testuser" vb.
        private string dogruKullanici = "admin"; // <--- BURAYA YAZMALISINIZ

        // Şifre de buraya gelecek
        private string dogruSifre = "1234";
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {


        }
 

        private void btnGiris_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace YourProjectName // Projenizin adı
{
    public partial class FormGiris : Form
    {
        // Sabit kullanıcı bilgileri BURAYA GELECEK
        private string dogruKullanici = "admin";
        private string dogruSifre = "1234";

        public FormGiris()
        {
           
            // lblUyari.Visible = false; gibi başlatma kodları buraya gelebilir
        }

        // btnGiris_Click metodu BURAYA GELECEK
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Metodun içindeki kod buraya gelecek
        }
    }
}