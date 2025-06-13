namespace BST102_OtoSys_FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPart = new Label();
            txtPart = new TextBox();
            lblMarka = new Label();
            lblModel = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            lblTur = new Label();
            cmbTur = new ComboBox();
            lblBaslangicTarihi = new Label();
            dtpBaslangic = new DateTimePicker();
            dgvAraclar = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            btnForm2 = new Button();
            dtpBitis = new DateTimePicker();
            lblBitisTarihi = new Label();
            lblMaliyet = new Label();
            numUretimAdedi = new NumericUpDown();
            lblUretimAdedi = new Label();
            groupBox1 = new GroupBox();
            txtMaliyet = new NumericUpDown();
            btnTemizle = new Button();
            chkSatildimi = new CheckBox();
            label1 = new Label();
            lblToplamUretim = new Label();
            lblToplamMaliyet = new Label();
            lblSatilanMaliyet = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUretimAdedi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaliyet).BeginInit();
            SuspendLayout();
            // 
            // lblPart
            // 
            lblPart.AutoSize = true;
            lblPart.Location = new Point(45, 33);
            lblPart.Name = "lblPart";
            lblPart.Size = new Size(53, 15);
            lblPart.TabIndex = 0;
            lblPart.Text = "Part No :";
            // 
            // txtPart
            // 
            txtPart.Location = new Point(104, 30);
            txtPart.Name = "txtPart";
            txtPart.ReadOnly = true;
            txtPart.Size = new Size(121, 23);
            txtPart.TabIndex = 1;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(52, 78);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(46, 15);
            lblMarka.TabIndex = 2;
            lblMarka.Text = "Marka :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(52, 121);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(47, 15);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model :";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(104, 75);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(121, 23);
            txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(104, 118);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(121, 23);
            txtModel.TabIndex = 5;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(67, 249);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(31, 15);
            lblTur.TabIndex = 6;
            lblTur.Text = "Tür :";
            // 
            // cmbTur
            // 
            cmbTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(104, 246);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(121, 23);
            cmbTur.TabIndex = 7;
            // 
            // lblBaslangicTarihi
            // 
            lblBaslangicTarihi.AutoSize = true;
            lblBaslangicTarihi.Location = new Point(30, 320);
            lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            lblBaslangicTarihi.Size = new Size(87, 15);
            lblBaslangicTarihi.TabIndex = 8;
            lblBaslangicTarihi.Text = "Başlangıç tarihi";
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(30, 338);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(175, 23);
            dtpBaslangic.TabIndex = 9;
            // 
            // dgvAraclar
            // 
            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(282, 12);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.ReadOnly = true;
            dgvAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAraclar.Size = new Size(1123, 547);
            dgvAraclar.TabIndex = 10;
            dgvAraclar.CellContentClick += dgvAraclar_CellContentClick;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(15, 445);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(87, 29);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(14, 498);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(245, 29);
            btnSil.TabIndex = 12;
            btnSil.Text = "Aracı Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(12, 530);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(247, 29);
            btnForm2.TabIndex = 13;
            btnForm2.Text = "Araç Bilgilerini Güncelle";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(30, 398);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.ShowCheckBox = true;
            dtpBitis.Size = new Size(175, 23);
            dtpBitis.TabIndex = 15;
            // 
            // lblBitisTarihi
            // 
            lblBitisTarihi.AutoSize = true;
            lblBitisTarihi.Location = new Point(30, 380);
            lblBitisTarihi.Name = "lblBitisTarihi";
            lblBitisTarihi.Size = new Size(59, 15);
            lblBitisTarihi.TabIndex = 14;
            lblBitisTarihi.Text = "Bitiş tarihi";
            // 
            // lblMaliyet
            // 
            lblMaliyet.AutoSize = true;
            lblMaliyet.Location = new Point(15, 168);
            lblMaliyet.Name = "lblMaliyet";
            lblMaliyet.Size = new Size(83, 15);
            lblMaliyet.TabIndex = 16;
            lblMaliyet.Text = "Birim Maliyet :";
            // 
            // numUretimAdedi
            // 
            numUretimAdedi.Location = new Point(104, 207);
            numUretimAdedi.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numUretimAdedi.Name = "numUretimAdedi";
            numUretimAdedi.Size = new Size(121, 23);
            numUretimAdedi.TabIndex = 18;
            // 
            // lblUretimAdedi
            // 
            lblUretimAdedi.AutoSize = true;
            lblUretimAdedi.Location = new Point(15, 209);
            lblUretimAdedi.Name = "lblUretimAdedi";
            lblUretimAdedi.Size = new Size(83, 15);
            lblUretimAdedi.TabIndex = 19;
            lblUretimAdedi.Text = "Üretim Adedi :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaliyet);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(chkSatildimi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblUretimAdedi);
            groupBox1.Controls.Add(lblPart);
            groupBox1.Controls.Add(numUretimAdedi);
            groupBox1.Controls.Add(txtPart);
            groupBox1.Controls.Add(lblMarka);
            groupBox1.Controls.Add(lblMaliyet);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(txtMarka);
            groupBox1.Controls.Add(lblBitisTarihi);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(lblTur);
            groupBox1.Controls.Add(cmbTur);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(lblBaslangicTarihi);
            groupBox1.Controls.Add(dtpBaslangic);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 480);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Araç Ekleme";
            // 
            // txtMaliyet
            // 
            txtMaliyet.Location = new Point(104, 166);
            txtMaliyet.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            txtMaliyet.Name = "txtMaliyet";
            txtMaliyet.Size = new Size(121, 23);
            txtMaliyet.TabIndex = 23;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(138, 445);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(87, 29);
            btnTemizle.TabIndex = 22;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // chkSatildimi
            // 
            chkSatildimi.AutoSize = true;
            chkSatildimi.Location = new Point(104, 286);
            chkSatildimi.Name = "chkSatildimi";
            chkSatildimi.Size = new Size(15, 14);
            chkSatildimi.TabIndex = 21;
            chkSatildimi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 285);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "Satıldı mı :";
            // 
            // lblToplamUretim
            // 
            lblToplamUretim.AutoSize = true;
            lblToplamUretim.Location = new Point(465, 580);
            lblToplamUretim.Name = "lblToplamUretim";
            lblToplamUretim.Size = new Size(96, 15);
            lblToplamUretim.TabIndex = 22;
            lblToplamUretim.Text = "lblToplamUretim";
            // 
            // lblToplamMaliyet
            // 
            lblToplamMaliyet.AutoSize = true;
            lblToplamMaliyet.Location = new Point(883, 580);
            lblToplamMaliyet.Name = "lblToplamMaliyet";
            lblToplamMaliyet.Size = new Size(99, 15);
            lblToplamMaliyet.TabIndex = 23;
            lblToplamMaliyet.Text = "lblToplamMaliyet";
            // 
            // lblSatilanMaliyet
            // 
            lblSatilanMaliyet.AutoSize = true;
            lblSatilanMaliyet.Location = new Point(1311, 580);
            lblSatilanMaliyet.Name = "lblSatilanMaliyet";
            lblSatilanMaliyet.Size = new Size(94, 15);
            lblSatilanMaliyet.TabIndex = 24;
            lblSatilanMaliyet.Text = "lblSatilanMaliyet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1212, 580);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 27;
            label2.Text = "Satılan Maliyet : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(779, 580);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 26;
            label3.Text = "Toplam Maliyet : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 580);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 25;
            label4.Text = "Toplam Üretim : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 614);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lblSatilanMaliyet);
            Controls.Add(lblToplamMaliyet);
            Controls.Add(btnSil);
            Controls.Add(lblToplamUretim);
            Controls.Add(groupBox1);
            Controls.Add(btnForm2);
            Controls.Add(dgvAraclar);
            Name = "Form1";
            Text = "OtoSys - Araç Takip";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUretimAdedi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtMaliyet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPart;
        private TextBox txtPart;
        private Label lblMarka;
        private Label lblModel;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label lblTur;
        private ComboBox cmbTur;
        private Label lblBaslangicTarihi;
        private DateTimePicker dtpBaslangic;
        private DataGridView dgvAraclar;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnForm2;
        private DateTimePicker dtpBitis;
        private Label lblBitisTarihi;
        private Label lblMaliyet;
        private NumericUpDown numUretimAdedi;
        private Label lblUretimAdedi;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox chkSatildimi;
        private Label lblToplamUretim;
        private Label lblToplamMaliyet;
        private Label lblSatilanMaliyet;
        private Button btnTemizle;
        private NumericUpDown txtMaliyet;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
