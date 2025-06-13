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
            lblAracId = new Label();
            txtİD2 = new TextBox();
            txtMarka2 = new TextBox();
            txtModel2 = new TextBox();
            txtMarka = new Label();
            txtModel = new Label();
            numUretimAdedi = new Label();
            txtMaliyet = new Label();
            txtSatisTutari = new Label();
            chkSatildimi2 = new CheckBox();
            btnGuncelle = new Button();
            label1 = new Label();
            btnIptal2 = new Button();
            numUretimAdedi2 = new NumericUpDown();
            txtMaliyet2 = new NumericUpDown();
            cmbTur2 = new ComboBox();
            dtpBitis2 = new DateTimePicker();
            lblBitisTarihi2 = new Label();
            lblBaslangicTarihi2 = new Label();
            dtpBaslangic2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numUretimAdedi2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaliyet2).BeginInit();
            SuspendLayout();
            // 
            // lblAracId
            // 
            lblAracId.AutoSize = true;
            lblAracId.Location = new Point(48, 35);
            lblAracId.Name = "lblAracId";
            lblAracId.Size = new Size(53, 15);
            lblAracId.TabIndex = 0;
            lblAracId.Text = "Part No :";
            // 
            // txtİD2
            // 
            txtİD2.Location = new Point(107, 32);
            txtİD2.Name = "txtİD2";
            txtİD2.ReadOnly = true;
            txtİD2.Size = new Size(130, 23);
            txtİD2.TabIndex = 1;
            // 
            // txtMarka2
            // 
            txtMarka2.Location = new Point(107, 61);
            txtMarka2.Name = "txtMarka2";
            txtMarka2.Size = new Size(130, 23);
            txtMarka2.TabIndex = 2;
            // 
            // txtModel2
            // 
            txtModel2.Location = new Point(107, 90);
            txtModel2.Name = "txtModel2";
            txtModel2.Size = new Size(130, 23);
            txtModel2.TabIndex = 3;
            // 
            // txtMarka
            // 
            txtMarka.AutoSize = true;
            txtMarka.Location = new Point(55, 64);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(46, 15);
            txtMarka.TabIndex = 5;
            txtMarka.Text = "Marka :";
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Location = new Point(54, 93);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(47, 15);
            txtModel.TabIndex = 6;
            txtModel.Text = "Model :";
            // 
            // numUretimAdedi
            // 
            numUretimAdedi.AutoSize = true;
            numUretimAdedi.Location = new Point(18, 121);
            numUretimAdedi.Name = "numUretimAdedi";
            numUretimAdedi.Size = new Size(83, 15);
            numUretimAdedi.TabIndex = 7;
            numUretimAdedi.Text = "Üretim Adedi :";
            // 
            // txtMaliyet
            // 
            txtMaliyet.AutoSize = true;
            txtMaliyet.Location = new Point(18, 150);
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(83, 15);
            txtMaliyet.TabIndex = 8;
            txtMaliyet.Text = "Birim Maliyet :";
            // 
            // txtSatisTutari
            // 
            txtSatisTutari.AutoSize = true;
            txtSatisTutari.Location = new Point(70, 180);
            txtSatisTutari.Name = "txtSatisTutari";
            txtSatisTutari.Size = new Size(31, 15);
            txtSatisTutari.TabIndex = 9;
            txtSatisTutari.Text = "Tür :";
            // 
            // chkSatildimi2
            // 
            chkSatildimi2.AutoSize = true;
            chkSatildimi2.Location = new Point(107, 206);
            chkSatildimi2.Name = "chkSatildimi2";
            chkSatildimi2.Size = new Size(15, 14);
            chkSatildimi2.TabIndex = 12;
            chkSatildimi2.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(153, 370);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(84, 34);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 205);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 14;
            label1.Text = "SATILDI:";
            // 
            // btnIptal2
            // 
            btnIptal2.Location = new Point(21, 370);
            btnIptal2.Name = "btnIptal2";
            btnIptal2.Size = new Size(84, 34);
            btnIptal2.TabIndex = 15;
            btnIptal2.Text = "İptal";
            btnIptal2.UseVisualStyleBackColor = true;
            btnIptal2.Click += btnIptal2_Click;
            // 
            // numUretimAdedi2
            // 
            numUretimAdedi2.Location = new Point(107, 119);
            numUretimAdedi2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numUretimAdedi2.Name = "numUretimAdedi2";
            numUretimAdedi2.Size = new Size(130, 23);
            numUretimAdedi2.TabIndex = 16;
            // 
            // txtMaliyet2
            // 
            txtMaliyet2.Location = new Point(107, 148);
            txtMaliyet2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtMaliyet2.Name = "txtMaliyet2";
            txtMaliyet2.Size = new Size(130, 23);
            txtMaliyet2.TabIndex = 17;
            // 
            // cmbTur2
            // 
            cmbTur2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur2.FormattingEnabled = true;
            cmbTur2.Location = new Point(107, 177);
            cmbTur2.Name = "cmbTur2";
            cmbTur2.Size = new Size(130, 23);
            cmbTur2.TabIndex = 18;
            // 
            // dtpBitis2
            // 
            dtpBitis2.Location = new Point(18, 314);
            dtpBitis2.Name = "dtpBitis2";
            dtpBitis2.ShowCheckBox = true;
            dtpBitis2.Size = new Size(219, 23);
            dtpBitis2.TabIndex = 22;
            // 
            // lblBitisTarihi2
            // 
            lblBitisTarihi2.AutoSize = true;
            lblBitisTarihi2.Location = new Point(18, 296);
            lblBitisTarihi2.Name = "lblBitisTarihi2";
            lblBitisTarihi2.Size = new Size(59, 15);
            lblBitisTarihi2.TabIndex = 21;
            lblBitisTarihi2.Text = "Bitiş tarihi";
            // 
            // lblBaslangicTarihi2
            // 
            lblBaslangicTarihi2.AutoSize = true;
            lblBaslangicTarihi2.Location = new Point(18, 236);
            lblBaslangicTarihi2.Name = "lblBaslangicTarihi2";
            lblBaslangicTarihi2.Size = new Size(87, 15);
            lblBaslangicTarihi2.TabIndex = 19;
            lblBaslangicTarihi2.Text = "Başlangıç tarihi";
            // 
            // dtpBaslangic2
            // 
            dtpBaslangic2.Location = new Point(18, 254);
            dtpBaslangic2.Name = "dtpBaslangic2";
            dtpBaslangic2.Size = new Size(219, 23);
            dtpBaslangic2.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 426);
            Controls.Add(dtpBitis2);
            Controls.Add(lblBitisTarihi2);
            Controls.Add(lblBaslangicTarihi2);
            Controls.Add(dtpBaslangic2);
            Controls.Add(cmbTur2);
            Controls.Add(txtMaliyet2);
            Controls.Add(numUretimAdedi2);
            Controls.Add(btnIptal2);
            Controls.Add(label1);
            Controls.Add(btnGuncelle);
            Controls.Add(chkSatildimi2);
            Controls.Add(txtSatisTutari);
            Controls.Add(txtMaliyet);
            Controls.Add(numUretimAdedi);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(txtModel2);
            Controls.Add(txtMarka2);
            Controls.Add(txtİD2);
            Controls.Add(lblAracId);
            Name = "Form2";
            Text = "Güncelleme Formu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numUretimAdedi2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaliyet2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAracId;
        private TextBox txtİD2;
        private TextBox txtMarka2;
        private TextBox txtModel2;
        private Label txtMarka;
        private Label txtModel;
        private Label numUretimAdedi;
        private Label txtMaliyet;
        private Label txtSatisTutari;
        private CheckBox chkSatildimi2;
        private Button btnGuncelle;
        private Label label1;
        private Button btnIptal2;
        private NumericUpDown numUretimAdedi2;
        private NumericUpDown txtMaliyet2;
        private ComboBox cmbTur2;
        private DateTimePicker dtpBitis2;
        private Label lblBitisTarihi2;
        private Label lblBaslangicTarihi2;
        private DateTimePicker dtpBaslangic2;
    }
}