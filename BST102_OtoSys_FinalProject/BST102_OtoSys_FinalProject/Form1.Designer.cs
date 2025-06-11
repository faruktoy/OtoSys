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
            lblPlaka = new Label();
            txtPlaka = new TextBox();
            lblMarka = new Label();
            lblModel = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            lblTur = new Label();
            cmbTur = new ComboBox();
            lblGirisTarihi = new Label();
            dtpGirisTarihi = new DateTimePicker();
            dgvAraclar = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            btnForm2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            SuspendLayout();
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Location = new Point(52, 109);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(35, 15);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "Plaka";
            lblPlaka.Click += label1_Click;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(112, 101);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(100, 23);
            txtPlaka.TabIndex = 1;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(48, 158);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(40, 15);
            lblMarka.TabIndex = 2;
            lblMarka.Text = "Marka";
            lblMarka.Click += label2_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(46, 208);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(112, 150);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(100, 23);
            txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(112, 200);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 5;
            txtModel.TextChanged += txtModel_TextChanged;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(52, 247);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(25, 15);
            lblTur.TabIndex = 6;
            lblTur.Text = "Tur";
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(91, 244);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(121, 23);
            cmbTur.TabIndex = 7;
            // 
            // lblGirisTarihi
            // 
            lblGirisTarihi.AutoSize = true;
            lblGirisTarihi.Location = new Point(27, 293);
            lblGirisTarihi.Name = "lblGirisTarihi";
            lblGirisTarihi.Size = new Size(60, 15);
            lblGirisTarihi.TabIndex = 8;
            lblGirisTarihi.Text = "Giris tarihi";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(91, 285);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(200, 23);
            dtpGirisTarihi.TabIndex = 9;
            dtpGirisTarihi.ValueChanged += dtpGirisTarihi_ValueChanged;
            // 
            // dgvAraclar
            // 
            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(298, 42);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.ReadOnly = true;
            dgvAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAraclar.Size = new Size(490, 309);
            dgvAraclar.TabIndex = 10;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(13, 349);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(112, 349);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(216, 349);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(75, 23);
            btnForm2.TabIndex = 13;
            btnForm2.Text = "Formu aç";
            btnForm2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(dgvAraclar);
            Controls.Add(dtpGirisTarihi);
            Controls.Add(lblGirisTarihi);
            Controls.Add(cmbTur);
            Controls.Add(lblTur);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Controls.Add(txtPlaka);
            Controls.Add(lblPlaka);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlaka;
        private TextBox txtPlaka;
        private Label lblMarka;
        private Label lblModel;
        private TextBox txtMarka;
        private TextBox txtModel;
        private Label lblTur;
        private ComboBox cmbTur;
        private Label lblGirisTarihi;
        private DateTimePicker dtpGirisTarihi;
        private DataGridView dgvAraclar;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnForm2;
    }
}
