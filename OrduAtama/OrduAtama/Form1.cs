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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region hakem işlemleri
        string HakemId = null;
        public void HakemGridDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            grdHakemBilgiDuzenlemeSilme.DataSource = db.Hakems.ToList();

            for (int i = 0; i < grdHakemBilgiDuzenlemeSilme.Columns.Count; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 6 || i == 7)
                {
                    grdHakemBilgiDuzenlemeSilme.Columns[i].Visible = true;
                }
                else
                {
                    grdHakemBilgiDuzenlemeSilme.Columns[i].Visible = false;
                }

                HakemId = null;

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
            cmbVizeDurumuGozlemci.DataSource = db.VizeDurumus.Select(s => s.Ad).ToList();

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

        public bool CiftKayitKontrolu(string Ad, string Soyad)
        {
            OrduAtamaContext db = new OrduAtamaContext();
            var a = db.Hakems.Where(w => w.Ad == Ad && w.SoyAd == Soyad).FirstOrDefault();
            if (a == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void HakemEkleme()
        {

            OrduAtamaContext db = new OrduAtamaContext();
            Hakem yeniHakem = new Hakem();
            yeniHakem.Ad = txtHakemAd.Text;
            yeniHakem.SoyAd = txtHakemSoyad.Text;
            yeniHakem.LisansNo = Convert.ToInt32(txtLisansNo.Text);
            yeniHakem.VizeDurumuId = cmbVizeDurumu.SelectedIndex + 1; ;// comboboxtan çekilecek
            yeniHakem.KlasmanId = cmbKlasmanBilgisi.SelectedIndex + 1;// comboboxtan çekilecek
            yeniHakem.KlasmanAdi = cmbKlasmanBilgisi.SelectedItem.ToString();
            yeniHakem.VizeDurumu = cmbVizeDurumu.SelectedItem.ToString();
            yeniHakem.AdSoyAd = txtHakemAd.Text + txtHakemSoyad.Text;
            db.Hakems.Add(yeniHakem);
            if (CiftKayitKontrolu(yeniHakem.Ad, yeniHakem.SoyAd) == true)
            {
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Aynı kayıt olduğundan bu kayıt yeniden yapılamaz!!");
            }

        }

        public void HakemSil(string HakemId)
        {
            OrduAtamaContext db = new OrduAtamaContext();
            int hakemId = Convert.ToInt32(HakemId);

            Hakem silinecekveri = db.Hakems.Where(w => w.Id == hakemId).FirstOrDefault();

            db.Hakems.Remove(silinecekveri);

            // Sorasında SaveChanges ile kaydetmeyi unutmuyoruz.
            db.SaveChanges();
        }
        #endregion

        #region Gözlemci işlemleri

        public bool GozlemciCiftKayitKontrolu(string Ad, string Soyad)
        {
            OrduAtamaContext db = new OrduAtamaContext();
            var a = db.Gozlemcis.Where(w => w.Ad == Ad && w.SoyAd == Soyad).FirstOrDefault();
            if (a == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void GozlemciEkleme()
        {

            OrduAtamaContext db = new OrduAtamaContext();
            Gozlemci yeniGozlemci = new Gozlemci();
            yeniGozlemci.Ad = txtGozlemciAdi.Text;
            yeniGozlemci.SoyAd = txtGozlemciSoyad.Text;
            yeniGozlemci.LisansNo = Convert.ToInt32(txtLisansNoGozlemci.Text);
            yeniGozlemci.VizeDurumuId = cmbVizeDurumuGozlemci.SelectedIndex + 1; ;// comboboxtan çekilecek
            yeniGozlemci.KlasmanId = cmbKlasmanBilgsiGozlemci.SelectedIndex + 1;// comboboxtan çekilecek
            yeniGozlemci.KlasmanAdi = cmbKlasmanBilgsiGozlemci.SelectedItem.ToString();
            yeniGozlemci.VizeDurumu = cmbVizeDurumuGozlemci.SelectedItem.ToString();
            //  yeniGozlemci.AdSoyAd = txtGozlemciAdi.Text + txtGozlemciSoyad.Text;
            db.Gozlemcis.Add(yeniGozlemci);
            if (GozlemciCiftKayitKontrolu(yeniGozlemci.Ad, yeniGozlemci.SoyAd) == true)
            {
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Aynı kayıt olduğundan bu kayıt yeniden yapılamaz!!");
            }

        }

        string GozlemciId = null;

        public void GozlemciGridDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            grdGozlemciBilgiDuzenlemeSilme.DataSource = db.Gozlemcis.ToList();

            for (int i = 0; i < grdGozlemciBilgiDuzenlemeSilme.Columns.Count; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 6 || i == 7)
                {
                    grdGozlemciBilgiDuzenlemeSilme.Columns[i].Visible = true;
                }
                else
                {
                    grdGozlemciBilgiDuzenlemeSilme.Columns[i].Visible = false;
                }
                GozlemciId = null;
            }
        }

        public void GozlemciKlasmanComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbKlasmanBilgsiGozlemci.DataSource = db.GozlemciKlasmen.Select(s => s.Ad).ToList();
        }

        private void txtLisansNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGozlemciSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtLisansNoGozlemci_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion

        #region takım işlemleri
        string TakimId = null;

        public bool CiftKayitKontroluTakim(string takimAd)
        {
            OrduAtamaContext db = new OrduAtamaContext();
            var a = db.Takimlars.Where(w => w.Ad == takimAd).FirstOrDefault();
            if (a == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void TakimEkleme()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            Takimlar yeniTakim = new Takimlar();
            yeniTakim.Ad = txtTakimAd.Text;


            db.Takimlars.Add(yeniTakim);
            if (CiftKayitKontroluTakim(yeniTakim.Ad) == true)
            {
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Aynı kayıt olduğundan bu kayıt yeniden yapılamaz!!");
            }
        }

        public void TakimGridDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            grdTakimListesi.DataSource = db.Takimlars.ToList();

            for (int i = 0; i < grdTakimListesi.Columns.Count; i++)
            {
                if (i == 0 || i == 1)
                {
                    grdTakimListesi.Columns[i].Visible = true;
                }
                else
                {
                    grdTakimListesi.Columns[i].Visible = false;
                }

                TakimId = null;

            }


        }


        #endregion

        #region hakem atama

        public void AtamaHakemAdSoyAdComboboxDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbAtamaOrtaHakem.DataSource = db.Hakems.Select(s => s.AdSoyAd).ToList();
            cmb1YardimciHakem.DataSource = db.Hakems.Select(s => s.AdSoyAd).ToList();
            cmb2YardimciHakem.DataSource = db.Hakems.Select(s => s.AdSoyAd).ToList();
            cmb4Hakem.DataSource = db.Hakems.Select(s => s.AdSoyAd).ToList();
        }
        public void AtamaTakimAdDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbAtamaEvSahibiTakim.DataSource = db.Takimlars.Select(s => s.Ad).ToList();
            cmbAtamaDeplasmanTakim.DataSource = db.Takimlars.Select(s => s.Ad).ToList();
        }
        public void AtamaKumeCmbDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbAtamaKumeBilgisi.DataSource = db.TakimKategoris.Select(s => s.Kodu).ToList();
        }
        public void AtamaGozlemciCmbDoldur()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            cmbAtamaGozlemci.DataSource = db.Gozlemcis.Select(s => s.Ad).ToList();
        }

        public bool AtamaItemleriniKontrolEt()
        {
            if (cmbAtamaDeplasmanTakim.SelectedIndex < 0 || cmbAtamaEvSahibiTakim.SelectedIndex < 0 || cmb1YardimciHakem.SelectedIndex < 0 || cmb2YardimciHakem.SelectedIndex < 0 || cmb4Hakem.SelectedIndex < 0 || cmbAtamaGozlemci.SelectedIndex < 0 || cmbAtamaOrtaHakem.SelectedIndex < 0 || cmbAtamaKumeBilgisi.SelectedIndex < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AyniMacAyniHakemKontrol()
        {
            if (cmbAtamaOrtaHakem.SelectedItem.ToString() == cmb1YardimciHakem.SelectedItem.ToString() || cmbAtamaOrtaHakem.SelectedItem.ToString() == cmb2YardimciHakem.SelectedItem.ToString() || cmbAtamaOrtaHakem.SelectedItem.ToString() == cmb4Hakem.SelectedItem.ToString() || cmb1YardimciHakem.SelectedItem.ToString() == cmb2YardimciHakem.SelectedItem.ToString() || cmb1YardimciHakem.SelectedItem.ToString() == cmb4Hakem.SelectedItem.ToString())
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool AyniTakimKontrol()
        {
            if (cmbAtamaDeplasmanTakim.SelectedItem.ToString() == cmbAtamaEvSahibiTakim.SelectedIndex.ToString())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AtamaYap()
        {
            OrduAtamaContext db = new OrduAtamaContext();
            MacBilgisi yeniMac = new MacBilgisi();
           yeniMac.OrtaHakemAd= 
            db.Hakems.Add(yeniHakem);
            if (CiftKayitKontrolu(yeniHakem.Ad, yeniHakem.SoyAd) == true)
            {
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Aynı kayıt olduğundan bu kayıt yeniden yapılamaz!!");
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            HakemKlasmanComboboxDoldur();
            GozlemciKlasmanComboboxDoldur();
            HakemGozlemciVizeComboboxDoldur();
            GozlemciGridDoldur();
            TakimGridDoldur();
            HakemGridDoldur();
            dtpAtamaTarihBilgisi.Format = DateTimePickerFormat.Custom;
            dtpAtamaTarihBilgisi.CustomFormat = "dd/MM/yyyy h:mm";
            AtamaGozlemciCmbDoldur();
            AtamaHakemAdSoyAdComboboxDoldur();
            AtamaKumeCmbDoldur();
            AtamaTakimAdDoldur();
        }

        #region butonclickler

        private void btnHakemEkleme_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHakemAd.Text) || string.IsNullOrEmpty(txtHakemSoyad.Text) || string.IsNullOrEmpty(txtLisansNo.Text) || cmbKlasmanBilgisi.SelectedIndex < 0 || cmbVizeDurumu.SelectedIndex < 0)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!!");
            }
            else
            {
                HakemEkleme();
            }
            HakemGridDoldur();

        }

        private void btnHakemBilgiDuzenle_Click(object sender, EventArgs e)
        {
            if (HakemId == null)
            {
                MessageBox.Show("Lütfen Bir Hakem Kaydı Seçiniz");
            }
            else
            {
                FrmHakemBilgiGuncelle frmHakemBilgiGuncelle = new FrmHakemBilgiGuncelle();
                frmHakemBilgiGuncelle.HakemId = HakemId;
                frmHakemBilgiGuncelle.Show();
            }

        }

        private void btnHakemSil_Click(object sender, EventArgs e)
        {


            HakemSil(HakemId);
        }

        private void btnGozlemciDuzenle_Click(object sender, EventArgs e)
        {
            if (GozlemciId == null)
            {
                MessageBox.Show("Lütfen Bir Hakem Kaydı Seçiniz");
            }
            else
            {
                FrmGozlemciBilgiDuzenleme frmGozlemciBilgiGuncelle = new FrmGozlemciBilgiDuzenleme();
                frmGozlemciBilgiGuncelle.GozlemciId = GozlemciId;
                frmGozlemciBilgiGuncelle.Show();
            }

        }


        private void btnGozlemciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGozlemciSoyad.Text) || string.IsNullOrEmpty(txtGozlemciAdi.Text) || string.IsNullOrEmpty(txtLisansNoGozlemci.Text) || cmbKlasmanBilgsiGozlemci.SelectedIndex < 0 || cmbVizeDurumuGozlemci.SelectedIndex < 0)
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!!");
            }
            else
            {
                GozlemciEkleme();
            }
            GozlemciGridDoldur();

        }

        private void btnHakemCezaGirisi_Click(object sender, EventArgs e)
        {

            FrmHakemCezaGirisi frmHakemCezaGirisi = new FrmHakemCezaGirisi();
            frmHakemCezaGirisi.Show();


        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTakimAd.Text))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz");
            }
            else
            {
                TakimEkleme();
            }
        }

        private void btnAtamaOnayi_Click(object sender, EventArgs e)
        {
            if (AtamaItemleriniKontrolEt() == false)
            {
                MessageBox.Show("Lütfen Eksik Bilgileri Seçiniz");
            }
            else
            {
                if (AyniMacAyniHakemKontrol() == false)
                {
                    MessageBox.Show("BİR HAKEM BİR MAÇA BİRDEN FAZLA KERE ATANAMAZ!!!");
                }
                else
                {
                    if (AyniTakimKontrol() == false)
                    {
                        MessageBox.Show("Lütfen Farklı Takımlar Seçiniz");
                    }
                    else
                    {
                        AtamaYap();
                    }
                }

            }
        }


        #endregion

        #region grid  cell clikler

        private void grdHakemBilgiDuzenlemeSilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HakemId = grdHakemBilgiDuzenlemeSilme.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(HakemId);
        }

        private void grdGozlemciBilgiDuzenlemeSilme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GozlemciId = grdGozlemciBilgiDuzenlemeSilme.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(GozlemciId);
        }

        private void grdTakimListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TakimId = grdTakimListesi.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(TakimId);
        }
        #endregion

        private void btnTakimBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if (TakimId == null)
            {
                MessageBox.Show("Lütfen Bir Takım Kaydı Seçiniz");
            }
            else
            {
                FrmTakimGuncelle frmTakimGuncelle = new FrmTakimGuncelle();
                frmTakimGuncelle.takimId = TakimId;
                frmTakimGuncelle.Show();
            }
        }


















    }
}
