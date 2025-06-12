namespace BST102_OtoSys_FinalProject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblUyari = new Label();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(106, 94);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Cursor = Cursors.IBeam;
            txtSifre.Location = new Point(106, 141);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(109, 180);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş yap";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(27, 97);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(73, 15);
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(43, 144);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(30, 15);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre";
            // 
            // lblUyari
            // 
            lblUyari.AutoSize = true;
            lblUyari.ForeColor = Color.Red;
            lblUyari.Location = new Point(109, 238);
            lblUyari.Name = "lblUyari";
            lblUyari.Size = new Size(70, 15);
            lblUyari.TabIndex = 5;
            lblUyari.Text = "Hatalı Giriş !";
            lblUyari.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 284);
            Controls.Add(lblUyari);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            ForeColor = Color.Black;
            Name = "LoginForm";
            Text = "Kullanıcı Girişi";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGiris;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private Label lblUyari;
    }
}