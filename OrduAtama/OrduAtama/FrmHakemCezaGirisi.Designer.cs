namespace OrduAtama
{
    partial class FrmHakemCezaGirisi
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
            this.cmbHakemAdSoyad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdHakemCezaGoruntule = new System.Windows.Forms.DataGridView();
            this.txtCezaHaftasi = new System.Windows.Forms.TextBox();
            this.btnCezaVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdHakemCezaGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHakemAdSoyad
            // 
            this.cmbHakemAdSoyad.FormattingEnabled = true;
            this.cmbHakemAdSoyad.Location = new System.Drawing.Point(29, 51);
            this.cmbHakemAdSoyad.Name = "cmbHakemAdSoyad";
            this.cmbHakemAdSoyad.Size = new System.Drawing.Size(141, 21);
            this.cmbHakemAdSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ceza Verilecek Hakem Bilgisi";
            // 
            // grdHakemCezaGoruntule
            // 
            this.grdHakemCezaGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHakemCezaGoruntule.Location = new System.Drawing.Point(29, 136);
            this.grdHakemCezaGoruntule.Name = "grdHakemCezaGoruntule";
            this.grdHakemCezaGoruntule.ReadOnly = true;
            this.grdHakemCezaGoruntule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHakemCezaGoruntule.Size = new System.Drawing.Size(565, 400);
            this.grdHakemCezaGoruntule.TabIndex = 47;
            // 
            // txtCezaHaftasi
            // 
            this.txtCezaHaftasi.Location = new System.Drawing.Point(209, 52);
            this.txtCezaHaftasi.Name = "txtCezaHaftasi";
            this.txtCezaHaftasi.Size = new System.Drawing.Size(141, 20);
            this.txtCezaHaftasi.TabIndex = 48;
            this.txtCezaHaftasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCezaHaftasi_KeyPress);
            // 
            // btnCezaVer
            // 
            this.btnCezaVer.Location = new System.Drawing.Point(29, 93);
            this.btnCezaVer.Name = "btnCezaVer";
            this.btnCezaVer.Size = new System.Drawing.Size(321, 23);
            this.btnCezaVer.TabIndex = 49;
            this.btnCezaVer.Text = "Ceza Ver";
            this.btnCezaVer.UseVisualStyleBackColor = true;
            this.btnCezaVer.Click += new System.EventHandler(this.btnCezaVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Verilecek Ceza Süresi(Hafta)";
            // 
            // FrmHakemCezaGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCezaVer);
            this.Controls.Add(this.txtCezaHaftasi);
            this.Controls.Add(this.grdHakemCezaGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHakemAdSoyad);
            this.Name = "FrmHakemCezaGirisi";
            this.Text = "FrmHakemCezaGirisi";
            this.Load += new System.EventHandler(this.FrmHakemCezaGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHakemCezaGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHakemAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdHakemCezaGoruntule;
        private System.Windows.Forms.TextBox txtCezaHaftasi;
        private System.Windows.Forms.Button btnCezaVer;
        private System.Windows.Forms.Label label2;

    }
}