using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMLAK
{
    public partial class frmKonutKayit : Form
    {
        public frmKonutKayit()
        {
            InitializeComponent();
        }

        private void frmKonutKayit_Load(object sender, EventArgs e)
        {
            Temizle();
            cMusteriSatici ms = new cMusteriSatici();
            ms.EmlakSahibiGetir(cbEmlakSahibi);

            txtIlanID.Text = cGenel.ilanID.ToString();
            cbEmlakSahibi.SelectedItem = cGenel.emlakSahibi;
            cbIslemTuru.SelectedItem = cGenel.islemTuru;
            txtAdres.Text = cGenel.adres;
            txtil.Text = cGenel.il;
            txtFiyat.Text = cGenel.fiyat.ToString();
            dtpEklenmeTarihi.Text = cGenel.eklenmeTarihi;
            txtMetrekare.Text = cGenel.metrekare.ToString();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            txtFiyat.Clear();
            txtMetrekare.Clear();
            txtAdres.Clear();
            txtAciklama.Clear();
            txtil.Clear();
            txtAidatTutari.Clear();
            txtIlanID.Clear();
            cbIslemTuru.SelectedIndex=-1;
            cbBalkonSayisi.SelectedIndex = -1;
            cbBanyoSayisi.SelectedIndex = -1;
            cbBinadakiKatSayisi.SelectedIndex = -1;
            cbBinaYasi.SelectedIndex = -1;
            cbBulunduguKat.SelectedIndex = -1;
            cbEmlakSahibi.SelectedIndex = -1;
            cbIsitma.SelectedIndex = -1;
            cbOdaSayisi.SelectedIndex = -1;
            txtFiyat.Text = "0";
            txtAidatTutari.Text = "0";
            txtMetrekare.Text = "0";

            foreach (Control item in this.gbDigerIc.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (Control item in this.gbDiger1.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (Control item in this.gbDisCepheOzellikleri.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (Control item in this.gbCevreOzellikleri.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            foreach (Control item in this.gbDosemeOzellikleri.Controls)
            {
                (item as CheckBox).Checked = false;
            }
            cbEmlakSahibi.Focus();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbEmlakSahibi.SelectedIndex != -1 && cbIslemTuru.SelectedIndex != -1 && txtAdres.Text != "" && txtFiyat.Text != "" && txtil.Text != "")
            {
                cKonut k = new cKonut();
                k.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                k.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                k.Adres = txtAdres.Text;
                k.Fiyat = Convert.ToDouble(txtFiyat.Text);
                k.Il = txtil.Text;
                k.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                k.OdaSayisi = cbOdaSayisi.SelectedItem.ToString();
                k.BanyoSayisi = cbBanyoSayisi.SelectedItem.ToString();
                k.BinaYasi = cbBinaYasi.SelectedItem.ToString();
                k.BalkonSayisi = cbBalkonSayisi.SelectedItem.ToString();
                k.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                k.BulunduguKat = Convert.ToInt32(cbBulunduguKat.SelectedItem.ToString());
                k.KatSayisi = Convert.ToInt32(cbBinadakiKatSayisi.SelectedItem.ToString());
                k.Aidat = Convert.ToDouble(txtAidatTutari.Text);
                k.Aciklama = txtAciklama.Text;
                k.Isitma = cbIsitma.SelectedItem.ToString();
                k.AhsapKaplama = Convert.ToBoolean(chbAhsapKaplama.Checked);
                k.AhsapParke = Convert.ToBoolean(chbAhsapParke.Checked);
                k.AnkastreMutfak = Convert.ToBoolean(chbAnkastreMutfak.Checked);
                k.Asansor = Convert.ToBoolean(chbAsansor.Checked);
                k.Bahce = Convert.ToBoolean(chbBahce.Checked);
                k.Boyali = Convert.ToBoolean(chbBoyali.Checked);
                k.CelikKapi = Convert.ToBoolean(chbCelikKapi.Checked);
                k.DenizManzarali = Convert.ToBoolean(chbDenizManzarasi.Checked);
                k.Dusakabin = Convert.ToBoolean(chbDusakabin.Checked);
                k.EbeveynBanyo = Convert.ToBoolean(chbEbeveynBanyo.Checked);
                k.GoruntuluDiyafon = Convert.ToBoolean(chbGoruntuluDiyafon.Checked);
                k.GranitKaplama = Convert.ToBoolean(chbGranitKaplama.Checked);
                k.Guvenlik = Convert.ToBoolean(chbGuvenlik.Checked);
                k.HaliDoseme = Convert.ToBoolean(chbHaliDoseme.Checked);
                k.Hastane = Convert.ToBoolean(chbHastane.Checked);
                k.Jenarator = Convert.ToBoolean(chbJenerator.Checked);
                k.KabloTvUydu = Convert.ToBoolean(chbKabloTVUydu.Checked);
                k.Kapici = Convert.ToBoolean(chbKapici.Checked);
                k.KartonpiyerTavan = Convert.ToBoolean(chbKartonpiyerTavan.Checked);
                k.LaminantParke = Convert.ToBoolean(chbLaminantParke.Checked);
                k.Mantolama = Convert.ToBoolean(chbMantolama.Checked);
                k.Market = Convert.ToBoolean(chbMarket.Checked);
                k.Marley = Convert.ToBoolean(chbMarley.Checked);
                k.Okul = Convert.ToBoolean(chbOkul.Checked);
                k.Otopark = Convert.ToBoolean(chbOtopark.Checked);
                k.PvcKaplamali = Convert.ToBoolean(chbPvcKaplamali.Checked);
                k.SidingKaplama = Convert.ToBoolean(chbSidingKaplama.Checked);
                k.SiteIcinde = Convert.ToBoolean(chbSiteIcinde.Checked);
                k.Sivali = Convert.ToBoolean(chbSivali.Checked);
                k.SporKompleksi = Convert.ToBoolean(chbSporTesisi.Checked);
                k.TerasVeranda = Convert.ToBoolean(chbTerasVeranda.Checked);
                k.YanginMerdiveni = Convert.ToBoolean(chbYanginMerdiveni.Checked);
                k.YuruyusParkuru = Convert.ToBoolean(chbYuruyusParkuru.Checked);

                if (k.EmlakKontrol(k))
                {
                    MessageBox.Show("Bu konut önceden kaydedilmiştir!", "Zaten Var!");
                    cbEmlakSahibi.Focus();
                }
                else
                {
                    if (k.EmlakEkle(k))
                    {
                        MessageBox.Show("Konut kayıt işlemi gerçekleştirildi!", "KAYIT EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        cbEmlakSahibi.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleşmedi!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbEmlakSahibi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show(" (*) ile  işaretlenen alanları boş geçemezsiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEmlakSahibi.Focus();
            }
        }
        private void btnEmlakSahibiGit_Click(object sender, EventArgs e)
        {
            frmMusteriSatici frm = new frmMusteriSatici();
            frm.ShowDialog();
            cMusteriSatici ms = new cMusteriSatici();
            cbEmlakSahibi.Items.Clear();
            ms.EmlakSahibiGetir(cbEmlakSahibi);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cKonut k = new cKonut();
                    bool Sonuc = Convert.ToBoolean(k.KonutSil(Convert.ToInt32(txtIlanID.Text)));
                    if (Sonuc)
                    {
                        MessageBox.Show("Konut bilgileri silindi!", "Dikkat !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        btnKaydet.Enabled = true;
                        cbEmlakSahibi.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Silme gerçekleşmedi!", "  HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException hata)
            {
                string Mesaj = hata.Message;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbEmlakSahibi.SelectedItem.ToString()) || string.IsNullOrEmpty(cbIslemTuru.SelectedItem.ToString()) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtil.Text))
            {
                MessageBox.Show("(*) ile  işaretlenen alanları boş geçemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEmlakSahibi.Focus();
            }
            else
            {
                cKonut k = new cKonut();
                k.IlanID = Convert.ToInt32(txtIlanID.Text);
                k.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                k.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                k.Adres = txtAdres.Text;
                k.Fiyat = Convert.ToDouble(txtFiyat.Text);
                k.Il = txtil.Text;
                k.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                k.OdaSayisi = cbOdaSayisi.SelectedItem.ToString();
                k.BanyoSayisi = cbBanyoSayisi.SelectedItem.ToString();
                k.BinaYasi = cbBinaYasi.SelectedItem.ToString();
                k.BalkonSayisi = cbBalkonSayisi.SelectedItem.ToString();
                k.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                k.BulunduguKat = Convert.ToInt32(cbBulunduguKat.SelectedItem.ToString());
                k.KatSayisi =Convert.ToInt32(cbBinadakiKatSayisi.SelectedItem.ToString());
                k.Aidat = Convert.ToDouble(txtAidatTutari.Text);
                k.Aciklama = txtAciklama.Text;
                k.Isitma = cbIsitma.SelectedItem.ToString();
                k.AhsapKaplama = Convert.ToBoolean(chbAhsapKaplama.Checked);
                k.AhsapParke = Convert.ToBoolean(chbAhsapParke.Checked);
                k.AnkastreMutfak = Convert.ToBoolean(chbAnkastreMutfak.Checked);
                k.Asansor = Convert.ToBoolean(chbAsansor.Checked);
                k.Bahce = Convert.ToBoolean(chbBahce.Checked);
                k.Boyali = Convert.ToBoolean(chbBoyali.Checked);
                k.CelikKapi = Convert.ToBoolean(chbCelikKapi.Checked);
                k.DenizManzarali = Convert.ToBoolean(chbDenizManzarasi.Checked);
                k.Dusakabin = Convert.ToBoolean(chbDusakabin.Checked);
                k.EbeveynBanyo = Convert.ToBoolean(chbEbeveynBanyo.Checked);
                k.GoruntuluDiyafon = Convert.ToBoolean(chbGoruntuluDiyafon.Checked);
                k.GranitKaplama = Convert.ToBoolean(chbGranitKaplama.Checked);
                k.Guvenlik = Convert.ToBoolean(chbGuvenlik.Checked);
                k.HaliDoseme = Convert.ToBoolean(chbHaliDoseme.Checked);
                k.Hastane = Convert.ToBoolean(chbHastane.Checked);
                k.Jenarator = Convert.ToBoolean(chbJenerator.Checked);
                k.KabloTvUydu = Convert.ToBoolean(chbKabloTVUydu.Checked);
                k.Kapici = Convert.ToBoolean(chbKapici.Checked);
                k.KartonpiyerTavan = Convert.ToBoolean(chbKartonpiyerTavan.Checked);
                k.LaminantParke = Convert.ToBoolean(chbLaminantParke.Checked);
                k.Mantolama = Convert.ToBoolean(chbMantolama.Checked);
                k.Market = Convert.ToBoolean(chbMarket.Checked);
                k.Marley = Convert.ToBoolean(chbMarley.Checked);
                k.Okul = Convert.ToBoolean(chbOkul.Checked);
                k.Otopark = Convert.ToBoolean(chbOtopark.Checked);
                k.PvcKaplamali = Convert.ToBoolean(chbPvcKaplamali.Checked);
                k.SidingKaplama = Convert.ToBoolean(chbSidingKaplama.Checked);
                k.SiteIcinde = Convert.ToBoolean(chbSiteIcinde.Checked);
                k.Sivali = Convert.ToBoolean(chbSivali.Checked);
                k.SporKompleksi = Convert.ToBoolean(chbSporTesisi.Checked);
                k.TerasVeranda = Convert.ToBoolean(chbTerasVeranda.Checked);
                k.YanginMerdiveni = Convert.ToBoolean(chbYanginMerdiveni.Checked);
                k.YuruyusParkuru = Convert.ToBoolean(chbYuruyusParkuru.Checked);
                

                if (k.EmlakKontrolByGuncelle(k))
                {
                    MessageBox.Show("Bu konut önceden kayıtlı.", "Zaten Mevcut!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbEmlakSahibi.Focus();
                }
                else
                {
                    if (k.EmlakGuncelle(k))
                    {
                        MessageBox.Show("Konut güncellendi.", "Değişiklik Gerçekleştirildi.");
                        Temizle();
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        btnKaydet.Enabled = true;
                    }
                    else { MessageBox.Show("Güncelleme gerçekleşmedi!"); cbEmlakSahibi.Focus(); }
                }
            }
        }


        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiyat.Text))
            {
                txtFiyat.Text = "0";
                txtFiyat.Select(0, 1);
            }
        }

        private void txtFiyat_MouseDown(object sender, MouseEventArgs e)
        {
            txtFiyat.Select(0, txtFiyat.Text.Length);
        }

        private void txtMetrekare_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetrekare.Text))
            {
                txtMetrekare.Text = "0";
                txtMetrekare.Select(0, 1);
            }
        }

        private void txtMetrekare_MouseDown(object sender, MouseEventArgs e)
        {
            txtMetrekare.Select(0, txtMetrekare.Text.Length);
        }

        private void txtAidatTutari_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAidatTutari.Text))
            {
                txtAidatTutari.Text = "0";
                txtAidatTutari.Select(0, 1);
            }
        }

        private void txtAidatTutari_MouseDown(object sender, MouseEventArgs e)
        {
            txtAidatTutari.Select(0, txtAidatTutari.Text.Length);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            frmAra frm = new frmAra();
            frm.ShowDialog();
        }
    }
}
