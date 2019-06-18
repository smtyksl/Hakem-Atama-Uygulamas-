namespace OrduAtama
{
    partial class FrmTakimGuncelle
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
            this.btnTakimGuncelle = new System.Windows.Forms.Button();
            this.txtTakimAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTakimGuncelle
            // 
            this.btnTakimGuncelle.Location = new System.Drawing.Point(35, 63);
            this.btnTakimGuncelle.Name = "btnTakimGuncelle";
            this.btnTakimGuncelle.Size = new System.Drawing.Size(300, 29);
            this.btnTakimGuncelle.TabIndex = 0;
            this.btnTakimGuncelle.Text = "Takım Güncelle";
            this.btnTakimGuncelle.UseVisualStyleBackColor = true;
            this.btnTakimGuncelle.Click += new System.EventHandler(this.btnTakimGuncelle_Click);
            // 
            // txtTakimAd
            // 
            this.txtTakimAd.Location = new System.Drawing.Point(172, 26);
            this.txtTakimAd.Name = "txtTakimAd";
            this.txtTakimAd.Size = new System.Drawing.Size(163, 20);
            this.txtTakimAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Değiştirilecek Takım Adı";
            // 
            // FrmTakimGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTakimAd);
            this.Controls.Add(this.btnTakimGuncelle);
            this.Name = "FrmTakimGuncelle";
            this.Text = "FrmTakimGuncelle";
            this.Load += new System.EventHandler(this.FrmTakimGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTakimGuncelle;
        private System.Windows.Forms.TextBox txtTakimAd;
        private System.Windows.Forms.Label label1;
    }
}