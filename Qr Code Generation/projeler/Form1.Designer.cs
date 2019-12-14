namespace projeler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltelno = new System.Windows.Forms.Label();
            this.lblsasi = new System.Windows.Forms.Label();
            this.lblbsahip = new System.Windows.Forms.Label();
            this.lblbno = new System.Windows.Forms.Label();
            this.lblbad = new System.Windows.Forms.Label();
            this.lblbdurum = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.kkolustur = new System.Windows.Forms.Button();
            this.lbldokuman = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblbasvuru = new System.Windows.Forms.Label();
            this.lblgec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltelno
            // 
            this.lbltelno.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltelno.Location = new System.Drawing.Point(417, 27);
            this.lbltelno.Name = "lbltelno";
            this.lbltelno.Size = new System.Drawing.Size(213, 56);
            this.lbltelno.TabIndex = 86;
            this.lbltelno.Text = "Telefon /\r\nTelephone 0262 527 61 30\r\n number";
            // 
            // lblsasi
            // 
            this.lblsasi.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsasi.Location = new System.Drawing.Point(9, 390);
            this.lblsasi.Name = "lblsasi";
            this.lblsasi.Size = new System.Drawing.Size(261, 72);
            this.lblsasi.TabIndex = 84;
            this.lblsasi.Text = "Şasi \r\nNumarası /***********\r\nChassis \r\nNumber";
            // 
            // lblbsahip
            // 
            this.lblbsahip.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbsahip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbsahip.Location = new System.Drawing.Point(9, 300);
            this.lblbsahip.Name = "lblbsahip";
            this.lblbsahip.Size = new System.Drawing.Size(376, 90);
            this.lblbsahip.TabIndex = 81;
            this.lblbsahip.Text = "Belge      RONENSANS LOJISTIK\r\nSahibi /    KIMYASAL URUNLER\r\nCertificate  SANAYI " +
    "VE TICARET \r\nHolde                   SIRKETI\r\n                             ";
            this.lblbsahip.Click += new System.EventHandler(this.lblbsahip_Click);
            // 
            // lblbno
            // 
            this.lblbno.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbno.Location = new System.Drawing.Point(9, 213);
            this.lblbno.Name = "lblbno";
            this.lblbno.Size = new System.Drawing.Size(261, 64);
            this.lblbno.TabIndex = 79;
            this.lblbno.Text = "Belge \r\nNo / **********\r\nCertificate \r\nNo";
            // 
            // lblbad
            // 
            this.lblbad.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbad.Location = new System.Drawing.Point(9, 112);
            this.lblbad.Name = "lblbad";
            this.lblbad.Size = new System.Drawing.Size(232, 69);
            this.lblbad.TabIndex = 78;
            this.lblbad.Text = "Belge\r\nAdı / Taşıt uygunluk belgesi\r\nCertificate  \r\nType";
            this.lblbad.Click += new System.EventHandler(this.lblbad_Click);
            // 
            // lblbdurum
            // 
            this.lblbdurum.Enabled = false;
            this.lblbdurum.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbdurum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbdurum.Location = new System.Drawing.Point(12, 27);
            this.lblbdurum.Name = "lblbdurum";
            this.lblbdurum.Size = new System.Drawing.Size(123, 56);
            this.lblbdurum.TabIndex = 77;
            this.lblbdurum.Text = "Belge \r\ndurumu / Uygun\r\nStatus";
            this.lblbdurum.UseCompatibleTextRendering = true;
            this.lblbdurum.Click += new System.EventHandler(this.lblbdurum_Click);
            // 
            // Resim
            // 
            this.Resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resim.Location = new System.Drawing.Point(658, 69);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(213, 188);
            this.Resim.TabIndex = 94;
            this.Resim.TabStop = false;
            // 
            // kkolustur
            // 
            this.kkolustur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kkolustur.BackColor = System.Drawing.Color.Beige;
            this.kkolustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kkolustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kkolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kkolustur.Location = new System.Drawing.Point(692, 285);
            this.kkolustur.Name = "kkolustur";
            this.kkolustur.Size = new System.Drawing.Size(140, 26);
            this.kkolustur.TabIndex = 93;
            this.kkolustur.Text = "Karekod Oluştur";
            this.kkolustur.UseVisualStyleBackColor = false;
            this.kkolustur.Click += new System.EventHandler(this.kkolustur_Click);
            // 
            // lbldokuman
            // 
            this.lbldokuman.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldokuman.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbldokuman.Location = new System.Drawing.Point(417, 390);
            this.lbldokuman.Name = "lbldokuman";
            this.lbldokuman.Size = new System.Drawing.Size(229, 72);
            this.lbldokuman.TabIndex = 101;
            this.lbldokuman.Text = "Döküman \r\nlink /           Download\r\nDocument \r\nlink";
            // 
            // lbltarih
            // 
            this.lbltarih.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltarih.Location = new System.Drawing.Point(417, 200);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(251, 77);
            this.lbltarih.TabIndex = 99;
            this.lbltarih.Text = "Belge\r\nTarihi / 20.12.2019\r\nDate of \r\nTermination";
            // 
            // lblbasvuru
            // 
            this.lblbasvuru.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbasvuru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbasvuru.Location = new System.Drawing.Point(417, 94);
            this.lblbasvuru.Name = "lblbasvuru";
            this.lblbasvuru.Size = new System.Drawing.Size(265, 76);
            this.lblbasvuru.TabIndex = 97;
            this.lblbasvuru.Text = "Verildiği\r\nbasvuru / 2019_5994\r\nApplication \r\nnumber";
            // 
            // lblgec
            // 
            this.lblgec.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblgec.Location = new System.Drawing.Point(417, 292);
            this.lblgec.Name = "lblgec";
            this.lblgec.Size = new System.Drawing.Size(215, 76);
            this.lblgec.TabIndex = 103;
            this.lblgec.Text = "Son \r\nGeçerlilik 20.12.2020\r\nTarihi /\r\nValidity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 529);
            this.Controls.Add(this.lblgec);
            this.Controls.Add(this.lbldokuman);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lblbasvuru);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.kkolustur);
            this.Controls.Add(this.lbltelno);
            this.Controls.Add(this.lblsasi);
            this.Controls.Add(this.lblbsahip);
            this.Controls.Add(this.lblbno);
            this.Controls.Add(this.lblbad);
            this.Controls.Add(this.lblbdurum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltelno;
        private System.Windows.Forms.Label lblsasi;
        private System.Windows.Forms.Label lblbsahip;
        private System.Windows.Forms.Label lblbno;
        private System.Windows.Forms.Label lblbad;
        private System.Windows.Forms.Label lblbdurum;
        public System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button kkolustur;
        private System.Windows.Forms.Label lbldokuman;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblbasvuru;
        private System.Windows.Forms.Label lblgec;
    }
}

