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
    public partial class FrmGozlemciBilgiDuzenleme : Form
    {
        public FrmGozlemciBilgiDuzenleme()
        {
            InitializeComponent();
        }

        public string GozlemciId;

        private void FrmGozlemciBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            GozlemciKlasmanComboboxDoldur();
            HakemGozlemciVizeComboboxDoldur();
            HakemBilgiGetir();
        }

        public void HakemBilgiGetir()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int gozlemciId = Convert.ToInt32(GozlemciId);
            var guncellenecekGozlemci = db.Gozlemcis.Where(w => w.Id == gozlemciId).FirstOrDefault();
            txtGozlemciAd.Text = guncellenecekGozlemci.Ad;
            txtGozlemciSoyad.Text = guncellenecekGozlemci.SoyAd;
            txtGozlemciNo.Text = guncellenecekGozlemci.LisansNo.ToString(); ;
            cmbVizeDurumu.SelectedIndex = Convert.ToInt32(guncellenecekGozlemci.VizeDurumuId) - 1; // comboboxtan çekilecek
            cmbGozlemciKlasmanBilgisi.SelectedIndex = Convert.ToInt32(guncellenecekGozlemci.KlasmanId) - 1;// comboboxtan çekilecek
        }

        public void GozlemciGuncelle()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int gozlemciId = Convert.ToInt32(GozlemciId);
            var guncellenecekGozlemci= db.Gozlemcis.Where(w => w.Id == gozlemciId).FirstOrDefault();
            guncellenecekGozlemci.Ad = txtGozlemciAd.Text;
            guncellenecekGozlemci.SoyAd = txtGozlemciSoyad.Text;
            guncellenecekGozlemci.LisansNo = Convert.ToInt32(txtGozlemciNo.Text);
            guncellenecekGozlemci.VizeDurumuId = cmbVizeDurumu.SelectedIndex + 1; ;// comboboxtan çekilecek
            guncellenecekGozlemci.KlasmanId = cmbGozlemciKlasmanBilgisi.SelectedIndex + 1;// comboboxtan çekilecek
            guncellenecekGozlemci.KlasmanAdi = cmbGozlemciKlasmanBilgisi.SelectedItem.ToString();
            guncellenecekGozlemci.VizeDurumu = cmbVizeDurumu.SelectedItem.ToString();
          //  guncellenecekGozlemci.AdSoyAd = txtHakemAd.Text + txtHakemSoyad.Text;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void GozlemciKlasmanComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbGozlemciKlasmanBilgisi.DataSource = db.GozlemciKlasmen.Select(s => s.Ad).ToList();

        }

        public void HakemGozlemciVizeComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbVizeDurumu.DataSource = db.VizeDurumus.Select(s => s.Ad).ToList();
        }

        private void btnHakemEkleme_Click(object sender, EventArgs e)
        {
            GozlemciGuncelle();
        }
    }
}
