namespace BST102_OtoSys_FinalProject
{
    partial class Form2
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
            lblaracid = new Label();
            txtMarka = new Label();
            txtModel = new Label();
            numUretimAdedi = new Label();
            txtaracid = new TextBox();
            txtaracmarka = new TextBox();
            txtaracmodel = new TextBox();
            txtaracuretimadedi = new TextBox();
            txtaracmaliyet = new TextBox();
            txtaracsatıstutarı = new TextBox();
            txtMaliyet = new Label();
            txtSatisTutari = new Label();
            chkSatildiMi = new CheckBox();
            SuspendLayout();
            // 
            // lblaracid
            // 
            lblaracid.AutoSize = true;
            lblaracid.Location = new Point(70, 39);
            lblaracid.Name = "lblaracid";
            lblaracid.Size = new Size(48, 15);
            lblaracid.TabIndex = 0;
            lblaracid.Text = "Araç ID:";
            lblaracid.Click += label1_Click;
            // 
            // txtMarka
            // 
            txtMarka.AutoSize = true;
            txtMarka.Location = new Point(70, 74);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(43, 15);
            txtMarka.TabIndex = 1;
            txtMarka.Text = "Marka:";
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Location = new Point(70, 106);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(41, 15);
            txtModel.TabIndex = 2;
            txtModel.Text = "Model";
            // 
            // numUretimAdedi
            // 
            numUretimAdedi.AutoSize = true;
            numUretimAdedi.Location = new Point(70, 141);
            numUretimAdedi.Name = "numUretimAdedi";
            numUretimAdedi.Size = new Size(80, 15);
            numUretimAdedi.TabIndex = 3;
            numUretimAdedi.Text = "Üretim Adedi:";
            // 
            // txtaracid
            // 
            txtaracid.Location = new Point(176, 31);
            txtaracid.Name = "txtaracid";
            txtaracid.Size = new Size(100, 23);
            txtaracid.TabIndex = 4;
            // 
            // txtaracmarka
            // 
            txtaracmarka.Location = new Point(176, 71);
            txtaracmarka.Name = "txtaracmarka";
            txtaracmarka.Size = new Size(100, 23);
            txtaracmarka.TabIndex = 5;
            // 
            // txtaracmodel
            // 
            txtaracmodel.Location = new Point(176, 106);
            txtaracmodel.Name = "txtaracmodel";
            txtaracmodel.Size = new Size(100, 23);
            txtaracmodel.TabIndex = 6;
            // 
            // txtaracuretimadedi
            // 
            txtaracuretimadedi.Location = new Point(176, 138);
            txtaracuretimadedi.Name = "txtaracuretimadedi";
            txtaracuretimadedi.Size = new Size(100, 23);
            txtaracuretimadedi.TabIndex = 7;
            // 
            // txtaracmaliyet
            // 
            txtaracmaliyet.Location = new Point(176, 183);
            txtaracmaliyet.Name = "txtaracmaliyet";
            txtaracmaliyet.Size = new Size(100, 23);
            txtaracmaliyet.TabIndex = 8;
            // 
            // txtaracsatıstutarı
            // 
            txtaracsatıstutarı.Location = new Point(176, 222);
            txtaracsatıstutarı.Name = "txtaracsatıstutarı";
            txtaracsatıstutarı.Size = new Size(100, 23);
            txtaracsatıstutarı.TabIndex = 9;
            // 
            // txtMaliyet
            // 
            txtMaliyet.AutoSize = true;
            txtMaliyet.Location = new Point(72, 183);
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(49, 15);
            txtMaliyet.TabIndex = 10;
            txtMaliyet.Text = "Maliyet:";
            // 
            // txtSatisTutari
            // 
            txtSatisTutari.AutoSize = true;
            txtSatisTutari.Location = new Point(70, 230);
            txtSatisTutari.Name = "txtSatisTutari";
            txtSatisTutari.Size = new Size(68, 15);
            txtSatisTutari.TabIndex = 11;
            txtSatisTutari.Text = "Satış Tutarı:";
            // 
            // chkSatildiMi
            // 
            chkSatildiMi.AutoSize = true;
            chkSatildiMi.Location = new Point(176, 319);
            chkSatildiMi.Name = "chkSatildiMi";
            chkSatildiMi.Size = new Size(80, 19);
            chkSatildiMi.TabIndex = 12;
            chkSatildiMi.Text = "Satıldı mı?";
            chkSatildiMi.UseVisualStyleBackColor = true;
            chkSatildiMi.CheckedChanged += chkSatildiMi_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkSatildiMi);
            Controls.Add(txtSatisTutari);
            Controls.Add(txtMaliyet);
            Controls.Add(txtaracsatıstutarı);
            Controls.Add(txtaracmaliyet);
            Controls.Add(txtaracuretimadedi);
            Controls.Add(txtaracmodel);
            Controls.Add(txtaracmarka);
            Controls.Add(txtaracid);
            Controls.Add(numUretimAdedi);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblaracid);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblaracid;
        private Label txtMarka;
        private Label txtModel;
        private Label numUretimAdedi;
        private TextBox txtaracid;
        private TextBox txtaracmarka;
        private TextBox txtaracmodel;
        private TextBox txtaracuretimadedi;
        private TextBox txtaracmaliyet;
        private TextBox txtaracsatıstutarı;
        private Label txtMaliyet;
        private Label txtSatisTutari;
        private CheckBox chkSatildiMi;
    }
}