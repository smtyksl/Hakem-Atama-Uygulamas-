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
    public partial class FrmHakemCezaGirisi : Form
    {
        public FrmHakemCezaGirisi()
        {
            InitializeComponent();
        }

        private void FrmHakemCezaGirisi_Load(object sender, EventArgs e)
        {
            HakemCezaComboboxDoldur();
            GrdHakemCezeDoldur();
        }

        public void HakemCezaComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbHakemAdSoyad.DataSource = db.Hakems.Select(s => s.AdSoyAd).ToList();
        }

        public void GrdHakemCezeDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            grdHakemCezaGoruntule.DataSource = db.HakemCezas.ToList();
            for (int i = 0; i < grdHakemCezaGoruntule.Columns.Count; i++)
            {
                if (i == 0 || i == 1 || i == 2 || i ==3  || i == 7 || i==8)
                {
                    grdHakemCezaGoruntule.Columns[i].Visible = false;
                }
                else
                {
                    grdHakemCezaGoruntule.Columns[i].Visible = true;
                }
               
            }

        }

        public void CezaGir()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            HakemCeza cezaliHakem = new HakemCeza();
            string adSad = cmbHakemAdSoyad.SelectedItem.ToString();
          
            var hakem= db.Hakems.Where(w => w.AdSoyAd == adSad).FirstOrDefault();

            int HakemId= hakem.Id;

            HakemCeza tmp = db.HakemCezas.Where(w => w.HakemId == HakemId).FirstOrDefault();

           
            

            if (tmp==null) //yeni kayıt
            {
                cezaliHakem.CezaBaslangicHafta = 1;// dinamik 
                cezaliHakem.CezaBitisHafta = 1 + Convert.ToInt32(txtCezaHaftasi.Text);
                db.HakemCezas.Add(cezaliHakem);
            }
            else      //gübncelleme
            {

                tmp.CezaBitisHafta = tmp.CezaBitisHafta + Convert.ToInt32(txtCezaHaftasi.Text);
            }

            //if (GozlemciCiftKayitKontrolu(yeniGozlemci.Ad, yeniGozlemci.SoyAd) == true)
            //{
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            //}
            //else
            //{
            //    MessageBox.Show("Aynı kayıt olduğundan bu kayıt yeniden yapılamaz!!");
            //}
        }

        private void btnCezaVer_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtCezaHaftasi.Text) || cmbHakemAdSoyad.SelectedIndex<0)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!!");
               
            }
            else
            {
                CezaGir();
            }
            GrdHakemCezeDoldur();
        }

        private void txtCezaHaftasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
