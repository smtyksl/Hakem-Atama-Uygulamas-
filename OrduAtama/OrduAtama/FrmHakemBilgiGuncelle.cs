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
    public partial class FrmHakemBilgiGuncelle : Form
    {
        public FrmHakemBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string HakemId;
        private void FrmHakemBilgiGuncelle_Load(object sender, EventArgs e)
        {
            HakemKlasmanComboboxDoldur();
            HakemGozlemciVizeComboboxDoldur();
            HakemBilgiGetir();
        }

        public void HakemBilgiGetir()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int hakemId = Convert.ToInt32(HakemId);
            var guncellenecekHakem = db.Hakems.Where(w => w.Id == hakemId).FirstOrDefault();
            txtHakemAd.Text = guncellenecekHakem.Ad;
            txtHakemSoyad.Text = guncellenecekHakem.SoyAd;
            txtLisansNo.Text = guncellenecekHakem.LisansNo.ToString(); ;
            cmbVizeDurumu.SelectedIndex = Convert.ToInt32(guncellenecekHakem.VizeDurumuId) - 1; // comboboxtan çekilecek
            cmbKlasmanBilgisi.SelectedIndex =Convert.ToInt32( guncellenecekHakem.KlasmanId) - 1;// comboboxtan çekilecek
      }

        public void HakemGuncelle()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int hakemId = Convert.ToInt32(HakemId);
            var guncellenecekHakem = db.Hakems.Where(w => w.Id == hakemId).FirstOrDefault();
            guncellenecekHakem.Ad = txtHakemAd.Text;
            guncellenecekHakem.SoyAd = txtHakemSoyad.Text;
            guncellenecekHakem.LisansNo = Convert.ToInt32(txtLisansNo.Text);
            guncellenecekHakem.VizeDurumuId = cmbVizeDurumu.SelectedIndex + 1; ;// comboboxtan çekilecek
            guncellenecekHakem.KlasmanId = cmbKlasmanBilgisi.SelectedIndex + 1;// comboboxtan çekilecek
            guncellenecekHakem.KlasmanAdi = cmbKlasmanBilgisi.SelectedItem.ToString();
            guncellenecekHakem.VizeDurumu = cmbVizeDurumu.SelectedItem.ToString();
            guncellenecekHakem.AdSoyAd = txtHakemAd.Text + txtHakemSoyad.Text;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void HakemKlasmanComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbKlasmanBilgisi.DataSource = db.Klasmen.Select(s => s.Ad).ToList();

        }

        public void HakemGozlemciVizeComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbVizeDurumu.DataSource = db.VizeDurumus.Select(s => s.Ad).ToList();
        }

        private void txtHakemAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtHakemSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void btnHakemEkleme_Click(object sender, EventArgs e)
        {
            HakemGuncelle();
        }

        private void txtHakemAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHakemAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
