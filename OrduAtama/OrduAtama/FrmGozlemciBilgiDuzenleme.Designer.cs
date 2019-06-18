namespace OrduAtama
{
    partial class FrmGozlemciBilgiDuzenleme
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
            this.cmbVizeDurumu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHakemEkleme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGozlemciKlasmanBilgisi = new System.Windows.Forms.ComboBox();
            this.txtGozlemciNo = new System.Windows.Forms.TextBox();
            this.txtGozlemciSoyad = new System.Windows.Forms.TextBox();
            this.txtGozlemciAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHakemSoyadi = new System.Windows.Forms.Label();
            this.lblHakemAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVizeDurumu
            // 
            this.cmbVizeDurumu.FormattingEnabled = true;
            this.cmbVizeDurumu.Location = new System.Drawing.Point(130, 113);
            this.cmbVizeDurumu.Name = "cmbVizeDurumu";
            this.cmbVizeDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbVizeDurumu.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Vize Durumu:";
            // 
            // btnHakemEkleme
            // 
            this.btnHakemEkleme.Location = new System.Drawing.Point(45, 140);
            this.btnHakemEkleme.Name = "btnHakemEkleme";
            this.btnHakemEkleme.Size = new System.Drawing.Size(490, 36);
            this.btnHakemEkleme.TabIndex = 55;
            this.btnHakemEkleme.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btnHakemEkleme.UseVisualStyleBackColor = true;
            this.btnHakemEkleme.Click += new System.EventHandler(this.btnHakemEkleme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "HAKEM EKLEME";
            // 
            // cmbGozlemciKlasmanBilgisi
            // 
            this.cmbGozlemciKlasmanBilgisi.FormattingEnabled = true;
            this.cmbGozlemciKlasmanBilgisi.Location = new System.Drawing.Point(370, 54);
            this.cmbGozlemciKlasmanBilgisi.Name = "cmbGozlemciKlasmanBilgisi";
            this.cmbGozlemciKlasmanBilgisi.Size = new System.Drawing.Size(151, 21);
            this.cmbGozlemciKlasmanBilgisi.TabIndex = 53;
            // 
            // txtGozlemciNo
            // 
            this.txtGozlemciNo.Location = new System.Drawing.Point(370, 82);
            this.txtGozlemciNo.Name = "txtGozlemciNo";
            this.txtGozlemciNo.Size = new System.Drawing.Size(151, 20);
            this.txtGozlemciNo.TabIndex = 52;
            // 
            // txtGozlemciSoyad
            // 
            this.txtGozlemciSoyad.Location = new System.Drawing.Point(130, 83);
            this.txtGozlemciSoyad.Name = "txtGozlemciSoyad";
            this.txtGozlemciSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtGozlemciSoyad.TabIndex = 51;
            // 
            // txtGozlemciAd
            // 
            this.txtGozlemciAd.Location = new System.Drawing.Point(130, 57);
            this.txtGozlemciAd.Name = "txtGozlemciAd";
            this.txtGozlemciAd.Size = new System.Drawing.Size(121, 20);
            this.txtGozlemciAd.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Lisans No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Klasman Bilgisi:";
            // 
            // lblHakemSoyadi
            // 
            this.lblHakemSoyadi.AutoSize = true;
            this.lblHakemSoyadi.Location = new System.Drawing.Point(42, 86);
            this.lblHakemSoyadi.Name = "lblHakemSoyadi";
            this.lblHakemSoyadi.Size = new System.Drawing.Size(79, 13);
            this.lblHakemSoyadi.TabIndex = 47;
            this.lblHakemSoyadi.Text = "Hakem Soyadı:";
            // 
            // lblHakemAdi
            // 
            this.lblHakemAdi.AutoSize = true;
            this.lblHakemAdi.Location = new System.Drawing.Point(42, 57);
            this.lblHakemAdi.Name = "lblHakemAdi";
            this.lblHakemAdi.Size = new System.Drawing.Size(62, 13);
            this.lblHakemAdi.TabIndex = 46;
            this.lblHakemAdi.Text = "Hakem Adı:";
            // 
            // FrmGozlemciBilgiDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 328);
            this.Controls.Add(this.cmbVizeDurumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHakemEkleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGozlemciKlasmanBilgisi);
            this.Controls.Add(this.txtGozlemciNo);
            this.Controls.Add(this.txtGozlemciSoyad);
            this.Controls.Add(this.txtGozlemciAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHakemSoyadi);
            this.Controls.Add(this.lblHakemAdi);
            this.Name = "FrmGozlemciBilgiDuzenleme";
            this.Text = "FrmGozlemciBilgiDuzenleme";
            this.Load += new System.EventHandler(this.FrmGozlemciBilgiDuzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVizeDurumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHakemEkleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGozlemciKlasmanBilgisi;
        private System.Windows.Forms.TextBox txtGozlemciNo;
        private System.Windows.Forms.TextBox txtGozlemciSoyad;
        private System.Windows.Forms.TextBox txtGozlemciAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHakemSoyadi;
        private System.Windows.Forms.Label lblHakemAdi;
    }
}