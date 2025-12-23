namespace SporSalonu
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
            txtUyeNo = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtOdeme = new TextBox();
            txtProgram = new TextBox();
            dtpKayit = new DateTimePicker();
            dtpAyrilma = new DateTimePicker();
            btnSorgula = new Button();
            btnGuncelle = new Button();
            btnOdemeSorgu = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtUyeNo
            // 
            txtUyeNo.Location = new Point(24, 21);
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.Size = new Size(118, 23);
            txtUyeNo.TabIndex = 7;
            txtUyeNo.Text = "Üye Numarası";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(24, 102);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(118, 23);
            txtTelefon.TabIndex = 8;
            txtTelefon.Text = "Telefonu";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(24, 60);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(118, 23);
            txtAdSoyad.TabIndex = 9;
            txtAdSoyad.Text = "Adı Soyadı";
            // 
            // txtOdeme
            // 
            txtOdeme.Location = new Point(24, 186);
            txtOdeme.Name = "txtOdeme";
            txtOdeme.Size = new Size(118, 23);
            txtOdeme.TabIndex = 10;
            txtOdeme.Text = "Aylık Ödeme Tutarı";
            // 
            // txtProgram
            // 
            txtProgram.Location = new Point(24, 142);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new Size(118, 23);
            txtProgram.TabIndex = 11;
            txtProgram.Text = "Çalışma Programı";
            // 
            // dtpKayit
            // 
            dtpKayit.Location = new Point(504, 117);
            dtpKayit.Name = "dtpKayit";
            dtpKayit.Size = new Size(200, 23);
            dtpKayit.TabIndex = 12;
            // 
            // dtpAyrilma
            // 
            dtpAyrilma.Location = new Point(504, 188);
            dtpAyrilma.Name = "dtpAyrilma";
            dtpAyrilma.Size = new Size(200, 23);
            dtpAyrilma.TabIndex = 13;
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new Point(191, 142);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(156, 23);
            btnSorgula.TabIndex = 14;
            btnSorgula.Text = "Üye Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(191, 102);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnOdemeSorgu
            // 
            btnOdemeSorgu.Location = new Point(191, 186);
            btnOdemeSorgu.Name = "btnOdemeSorgu";
            btnOdemeSorgu.Size = new Size(156, 23);
            btnOdemeSorgu.TabIndex = 16;
            btnOdemeSorgu.Text = "Ödeme Sorgula";
            btnOdemeSorgu.UseVisualStyleBackColor = true;
            btnOdemeSorgu.Click += btnOdemeSorgu_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(191, 60);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 17;
            btnSil.Text = "Üye Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(191, 21);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "Üye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 190);
            dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 123);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 20;
            label1.Text = "Kayıt Tarihi:";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 194);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 21;
            label2.Text = "Ayrılma Tarihi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnOdemeSorgu);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSorgula);
            Controls.Add(dtpAyrilma);
            Controls.Add(dtpKayit);
            Controls.Add(txtProgram);
            Controls.Add(txtOdeme);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTelefon);
            Controls.Add(txtUyeNo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUyeNo;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtOdeme;
        private TextBox txtProgram;
        private DateTimePicker dtpKayit;
        private DateTimePicker dtpAyrilma;
        private Button btnSorgula;
        private Button btnGuncelle;
        private Button btnOdemeSorgu;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
    }
}
