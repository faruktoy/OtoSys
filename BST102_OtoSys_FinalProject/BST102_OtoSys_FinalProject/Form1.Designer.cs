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
            lblBaslangicTarihi = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            dgvAraclar = new DataGridView();
            btnKaydet = new Button();
            btnSil = new Button();
            btnForm2 = new Button();
            dtpBitisTarihi = new DateTimePicker();
            lblBitisTarihi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            SuspendLayout();
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Location = new Point(24, 15);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(54, 15);
            lblPlaka.TabIndex = 0;
            lblPlaka.Text = "Şase NO:";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(84, 12);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(121, 23);
            txtPlaka.TabIndex = 1;
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(38, 67);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(40, 15);
            lblMarka.TabIndex = 2;
            lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(37, 126);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 3;
            lblModel.Text = "Model";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(84, 64);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(121, 23);
            txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(84, 123);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(121, 23);
            txtModel.TabIndex = 5;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(38, 190);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(25, 15);
            lblTur.TabIndex = 6;
            lblTur.Text = "Tür";
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(84, 187);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(121, 23);
            cmbTur.TabIndex = 7;
            // 
            // lblBaslangicTarihi
            // 
            lblBaslangicTarihi.AutoSize = true;
            lblBaslangicTarihi.Location = new Point(46, 252);
            lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            lblBaslangicTarihi.Size = new Size(87, 15);
            lblBaslangicTarihi.TabIndex = 8;
            lblBaslangicTarihi.Text = "Başlangıç tarihi";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(37, 270);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(121, 23);
            dtpBaslangicTarihi.TabIndex = 9;
            // 
            // dgvAraclar
            // 
            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.Location = new Point(226, 12);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.ReadOnly = true;
            dgvAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAraclar.Size = new Size(562, 515);
            dgvAraclar.TabIndex = 10;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(24, 459);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 11;
            btnKaydet.Text = "Ara";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(117, 459);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 12;
            btnSil.Text = "Temizle";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(24, 504);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(168, 23);
            btnForm2.TabIndex = 13;
            btnForm2.Text = "Bilgileri Güncelle";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(38, 351);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(121, 23);
            dtpBitisTarihi.TabIndex = 15;
            // 
            // lblBitisTarihi
            // 
            lblBitisTarihi.AutoSize = true;
            lblBitisTarihi.Location = new Point(64, 333);
            lblBitisTarihi.Name = "lblBitisTarihi";
            lblBitisTarihi.Size = new Size(59, 15);
            lblBitisTarihi.TabIndex = 14;
            lblBitisTarihi.Text = "Bitiş tarihi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 539);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(lblBitisTarihi);
            Controls.Add(btnForm2);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(dgvAraclar);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(lblBaslangicTarihi);
            Controls.Add(cmbTur);
            Controls.Add(lblTur);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Controls.Add(txtPlaka);
            Controls.Add(lblPlaka);
            Name = "Form1";
            Text = "OtoSys - Araç Takip";
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
        private Label lblBaslangicTarihi;
        private DateTimePicker dtpBaslangicTarihi;
        private DataGridView dgvAraclar;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnForm2;
        private DateTimePicker dtpBitisTarihi;
        private Label lblBitisTarihi;
    }
}
