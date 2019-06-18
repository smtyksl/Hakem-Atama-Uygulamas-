namespace OrduAtama
{
    partial class FrmHakemBilgiGuncelle
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
            this.cmbKlasmanBilgisi = new System.Windows.Forms.ComboBox();
            this.txtLisansNo = new System.Windows.Forms.TextBox();
            this.txtHakemSoyad = new System.Windows.Forms.TextBox();
            this.txtHakemAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHakemSoyadi = new System.Windows.Forms.Label();
            this.lblHakemAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVizeDurumu
            // 
            this.cmbVizeDurumu.FormattingEnabled = true;
            this.cmbVizeDurumu.Location = new System.Drawing.Point(134, 113);
            this.cmbVizeDurumu.Name = "cmbVizeDurumu";
            this.cmbVizeDurumu.Size = new System.Drawing.Size(121, 21);
            this.cmbVizeDurumu.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Vize Durumu:";
            // 
            // btnHakemEkleme
            // 
            this.btnHakemEkleme.Location = new System.Drawing.Point(49, 140);
            this.btnHakemEkleme.Name = "btnHakemEkleme";
            this.btnHakemEkleme.Size = new System.Drawing.Size(490, 36);
            this.btnHakemEkleme.TabIndex = 43;
            this.btnHakemEkleme.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btnHakemEkleme.UseVisualStyleBackColor = true;
            this.btnHakemEkleme.Click += new System.EventHandler(this.btnHakemEkleme_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "HAKEM EKLEME";
            // 
            // cmbKlasmanBilgisi
            // 
            this.cmbKlasmanBilgisi.FormattingEnabled = true;
            this.cmbKlasmanBilgisi.Location = new System.Drawing.Point(374, 54);
            this.cmbKlasmanBilgisi.Name = "cmbKlasmanBilgisi";
            this.cmbKlasmanBilgisi.Size = new System.Drawing.Size(151, 21);
            this.cmbKlasmanBilgisi.TabIndex = 41;
            // 
            // txtLisansNo
            // 
            this.txtLisansNo.Location = new System.Drawing.Point(374, 82);
            this.txtLisansNo.Name = "txtLisansNo";
            this.txtLisansNo.Size = new System.Drawing.Size(151, 20);
            this.txtLisansNo.TabIndex = 40;
            // 
            // txtHakemSoyad
            // 
            this.txtHakemSoyad.Location = new System.Drawing.Point(134, 83);
            this.txtHakemSoyad.Name = "txtHakemSoyad";
            this.txtHakemSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtHakemSoyad.TabIndex = 39;
            // 
            // txtHakemAd
            // 
            this.txtHakemAd.Location = new System.Drawing.Point(134, 57);
            this.txtHakemAd.Name = "txtHakemAd";
            this.txtHakemAd.Size = new System.Drawing.Size(121, 20);
            this.txtHakemAd.TabIndex = 38;
            this.txtHakemAd.TextChanged += new System.EventHandler(this.txtHakemAd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Lisans No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Klasman Bilgisi:";
            // 
            // lblHakemSoyadi
            // 
            this.lblHakemSoyadi.AutoSize = true;
            this.lblHakemSoyadi.Location = new System.Drawing.Point(46, 86);
            this.lblHakemSoyadi.Name = "lblHakemSoyadi";
            this.lblHakemSoyadi.Size = new System.Drawing.Size(79, 13);
            this.lblHakemSoyadi.TabIndex = 35;
            this.lblHakemSoyadi.Text = "Hakem Soyadı:";
            // 
            // lblHakemAdi
            // 
            this.lblHakemAdi.AutoSize = true;
            this.lblHakemAdi.Location = new System.Drawing.Point(46, 57);
            this.lblHakemAdi.Name = "lblHakemAdi";
            this.lblHakemAdi.Size = new System.Drawing.Size(62, 13);
            this.lblHakemAdi.TabIndex = 34;
            this.lblHakemAdi.Text = "Hakem Adı:";
            this.lblHakemAdi.Click += new System.EventHandler(this.lblHakemAdi_Click);
            // 
            // FrmHakemBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 335);
            this.Controls.Add(this.cmbVizeDurumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHakemEkleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKlasmanBilgisi);
            this.Controls.Add(this.txtLisansNo);
            this.Controls.Add(this.txtHakemSoyad);
            this.Controls.Add(this.txtHakemAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHakemSoyadi);
            this.Controls.Add(this.lblHakemAdi);
            this.Name = "FrmHakemBilgiGuncelle";
            this.Text = "FrmHakemBilgiGuncelle";
            this.Load += new System.EventHandler(this.FrmHakemBilgiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVizeDurumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHakemEkleme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKlasmanBilgisi;
        private System.Windows.Forms.TextBox txtLisansNo;
        private System.Windows.Forms.TextBox txtHakemSoyad;
        private System.Windows.Forms.TextBox txtHakemAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHakemSoyadi;
        private System.Windows.Forms.Label lblHakemAdi;
    }
}