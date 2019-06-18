using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrduAtama
{
    public partial class FrmTakimGuncelle : Form
    {
        public FrmTakimGuncelle()
        {
            InitializeComponent();
        }

        public string takimId;
        public void TakimBilgiGetir()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int TakimId = Convert.ToInt32(takimId);
            var takim = db.Takimlars.Where(w => w.Id == TakimId).FirstOrDefault();
            txtTakimAd.Text = takim.Ad;
        }
        public void TakimGuncelle()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int tkmId = Convert.ToInt32(takimId);
            var guncellenecekTakim = db.Takimlars.Where(w => w.Id == tkmId).FirstOrDefault();

            guncellenecekTakim.Ad =txtTakimAd.Text;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        private void FrmTakimGuncelle_Load(object sender, EventArgs e)
        {
            TakimBilgiGetir();
        }

        private void btnTakimGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTakimAd.Text))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!!");
            }
            else
            {
                TakimGuncelle();
            }
        }
    }
}
