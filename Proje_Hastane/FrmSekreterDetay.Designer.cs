namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.richDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.maskedTC = new System.Windows.Forms.MaskedTextBox();
            this.comboDoktor = new System.Windows.Forms.ComboBox();
            this.comboBrans = new System.Windows.Forms.ComboBox();
            this.maskedSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRandevuPaneli = new System.Windows.Forms.Button();
            this.btnBransPaneli = new System.Windows.Forms.Button();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(156, 80);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(81, 24);
            this.labelAdSoyad.TabIndex = 7;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ad-Soyad:";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Location = new System.Drawing.Point(156, 36);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(120, 24);
            this.labelTC.TabIndex = 5;
            this.labelTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = " T.C Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.richDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(11, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(10, 300);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(255, 36);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // richDuyuru
            // 
            this.richDuyuru.Location = new System.Drawing.Point(8, 28);
            this.richDuyuru.Name = "richDuyuru";
            this.richDuyuru.Size = new System.Drawing.Size(257, 256);
            this.richDuyuru.TabIndex = 0;
            this.richDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRandevuKaydet);
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.maskedTC);
            this.groupBox3.Controls.Add(this.comboDoktor);
            this.groupBox3.Controls.Add(this.comboBrans);
            this.groupBox3.Controls.Add(this.maskedSaat);
            this.groupBox3.Controls.Add(this.maskedTarih);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(316, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 500);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(107, 394);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(141, 31);
            this.btnRandevuKaydet.TabIndex = 14;
            this.btnRandevuKaydet.Text = "Kaydet";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(110, 338);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(86, 28);
            this.checkBoxDurum.TabIndex = 13;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // maskedTC
            // 
            this.maskedTC.Location = new System.Drawing.Point(110, 303);
            this.maskedTC.Mask = "00000000000";
            this.maskedTC.Name = "maskedTC";
            this.maskedTC.Size = new System.Drawing.Size(138, 29);
            this.maskedTC.TabIndex = 12;
            this.maskedTC.ValidatingType = typeof(int);
            // 
            // comboDoktor
            // 
            this.comboDoktor.FormattingEnabled = true;
            this.comboDoktor.Location = new System.Drawing.Point(110, 241);
            this.comboDoktor.Name = "comboDoktor";
            this.comboDoktor.Size = new System.Drawing.Size(138, 32);
            this.comboDoktor.TabIndex = 11;
            // 
            // comboBrans
            // 
            this.comboBrans.FormattingEnabled = true;
            this.comboBrans.Location = new System.Drawing.Point(110, 192);
            this.comboBrans.Name = "comboBrans";
            this.comboBrans.Size = new System.Drawing.Size(138, 32);
            this.comboBrans.TabIndex = 10;
            this.comboBrans.SelectedIndexChanged += new System.EventHandler(this.comboBrans_SelectedIndexChanged);
            // 
            // maskedSaat
            // 
            this.maskedSaat.Location = new System.Drawing.Point(110, 145);
            this.maskedSaat.Mask = "00:00";
            this.maskedSaat.Name = "maskedSaat";
            this.maskedSaat.Size = new System.Drawing.Size(138, 29);
            this.maskedSaat.TabIndex = 9;
            this.maskedSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTarih
            // 
            this.maskedTarih.Location = new System.Drawing.Point(110, 96);
            this.maskedTarih.Mask = "00/00/0000";
            this.maskedTarih.Name = "maskedTarih";
            this.maskedTarih.Size = new System.Drawing.Size(138, 29);
            this.maskedTarih.TabIndex = 8;
            this.maskedTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(110, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 29);
            this.txtID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "T.C No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(646, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 249);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(646, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 328);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(428, 300);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyurular);
            this.groupBox6.Controls.Add(this.btnRandevuPaneli);
            this.groupBox6.Controls.Add(this.btnBransPaneli);
            this.groupBox6.Controls.Add(this.btnDoktorPaneli);
            this.groupBox6.Location = new System.Drawing.Point(11, 519);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(621, 75);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnRandevuPaneli
            // 
            this.btnRandevuPaneli.Location = new System.Drawing.Point(325, 28);
            this.btnRandevuPaneli.Name = "btnRandevuPaneli";
            this.btnRandevuPaneli.Size = new System.Drawing.Size(110, 31);
            this.btnRandevuPaneli.TabIndex = 18;
            this.btnRandevuPaneli.Text = "Randevu Paneli";
            this.btnRandevuPaneli.UseVisualStyleBackColor = true;
            this.btnRandevuPaneli.Click += new System.EventHandler(this.btnRandevuPaneli_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Location = new System.Drawing.Point(171, 28);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(105, 31);
            this.btnBransPaneli.TabIndex = 17;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.UseVisualStyleBackColor = true;
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Location = new System.Drawing.Point(16, 28);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(108, 31);
            this.btnDoktorPaneli.TabIndex = 16;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = true;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(486, 28);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(110, 31);
            this.btnDuyurular.TabIndex = 19;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 607);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "FrmSekreterDetay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox richDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRandevuKaydet;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.MaskedTextBox maskedTC;
        private System.Windows.Forms.ComboBox comboDoktor;
        private System.Windows.Forms.ComboBox comboBrans;
        private System.Windows.Forms.MaskedTextBox maskedSaat;
        private System.Windows.Forms.MaskedTextBox maskedTarih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevuPaneli;
        private System.Windows.Forms.Button btnBransPaneli;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button btnDuyurular;
    }
}