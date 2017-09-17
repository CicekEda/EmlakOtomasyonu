using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMLAK
{
    public partial class frmIsyeriKayit : Form
    {
        public frmIsyeriKayit()
        {
            InitializeComponent();
        }

        private void frmIsyeriKayit_Load(object sender, EventArgs e)
        {
            Temizle();
            cMusteriSatici m = new cMusteriSatici();
            m.EmlakSahibiGetir(cbEmlakSahibi);


            txtIlanID.Text = (cGenel.ilanID).ToString();
            cbEmlakSahibi.SelectedItem = cGenel.emlakSahibi;
            cbIslemTuru.SelectedItem = cGenel.islemTuru;
            txtMetrekare.Text = (cGenel.metrekare).ToString();
            txtil.Text = cGenel.il;
            txtAdres.Text = cGenel.adres;
            txtFiyat.Text = (cGenel.fiyat).ToString();
            dtpEklenmeTarihi.Text = cGenel.eklenmeTarihi;


         
        }



      

        private void Temizle()
        {
            txtAciklama.Clear();
            txtAdres.Clear();
            txtFiyat.Clear();
            txtil.Clear();
            txtIlanID.Clear();
            txtMetrekare.Clear();
            cbBinadakiKatSayisi.SelectedIndex = -1;
            cbBulunduguKat.SelectedIndex = -1;
            cbEmlakSahibi.SelectedIndex = -1;
            cbIsitma.SelectedIndex = -1;
            cbIslemTuru.SelectedIndex = -1;

            foreach (Control item in this.gbDiger.Controls)
                (item as CheckBox).Checked = false;



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cIsyeri i = new cIsyeri();
            if (txtFiyat.Text.Trim() != "" &&  txtil.Text.Trim() != ""  && txtAdres.Text.Trim() != ""  && cbEmlakSahibi.SelectedIndex != -1
                && cbIslemTuru.SelectedIndex != -1 )
            {
               
                i.Fiyat = Convert.ToDouble(txtFiyat.Text);
                i.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                i.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                i.Il = txtil.Text;
                i.Adres = txtAdres.Text;
                i.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                i.Aciklama = txtAciklama.Text;
                i.BulunduguKat = Convert.ToInt32(cbBulunduguKat.SelectedItem);
                i.KatSayisi = Convert.ToInt32(cbBinadakiKatSayisi.SelectedItem);
                i.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                i.Isitma = cbIsitma.SelectedItem.ToString();
                i.Otopark = Convert.ToBoolean(chbOtopark.Checked);
                i.Guvenlik = Convert.ToBoolean(chbGuvenlik.Checked);
                i.YanginMerdiveni = Convert.ToBoolean(chbYanginMerdiveni.Checked);
                i.Jenarator = Convert.ToBoolean(chbJenerator.Checked);
                i.KabloTvUydu = Convert.ToBoolean(chbKabloTVUydu.Checked);
                i.TerasVeranda = Convert.ToBoolean(chbTerasVeranda.Checked);
               


                if (i.IlanKontrol(i))
                { MessageBox.Show("İlan zaten mevcut ", "Aynı ilan Girilemez !"); }
                else
                {
                    if (i.IlanEkle(i))
                    {
                        MessageBox.Show("İlan kayıt işlemi gerçekleştirildi!", "KAYIT EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        txtFiyat.Focus();
                    
                    }

                    else { MessageBox.Show("Kayıt gerçekleşmedi!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else { MessageBox.Show(" (*) ile  işaretlenen alanları boş geçemezsiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnEmlakSahibiGit_Click_1(object sender, EventArgs e)
        {
            frmMusteriSatici frm = new frmMusteriSatici(); 
            frm.ShowDialog();
            cbEmlakSahibi.Items.Clear();
            cMusteriSatici ms = new cMusteriSatici();
            ms.EmlakSahibiGetir(cbEmlakSahibi);
        }

   

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cIsyeri i = new cIsyeri();

                bool Sonuc = Convert.ToBoolean(i.IlanSil(Convert.ToInt32(txtIlanID.Text)));
                if (Sonuc)
                {
                    MessageBox.Show("Konut bilgileri silindi!", "Dikkat !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Temizle();
                    btnTemizle.Enabled = false;
                    btnSil.Enabled = false;
                    btnEkle.Enabled = true;
                }
                else { MessageBox.Show("Silme gerçekleşmedi!", "  HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error); txtFiyat.Focus(); }
            }
      }
    

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFiyat.Text.Trim() != "" && txtil.Text.Trim() != "" && txtAdres.Text.Trim() != "" && cbEmlakSahibi.SelectedIndex != -1
                && cbIslemTuru.SelectedIndex != -1)
            {
                cIsyeri i = new cIsyeri();
                i.IlanID = Convert.ToInt32(txtIlanID.Text);
                i.Fiyat = Convert.ToDouble(txtFiyat.Text);
                i.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                i.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                i.Il = txtil.Text;
                i.Adres = txtAdres.Text;
                i.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                i.Aciklama = txtAciklama.Text;
                i.BulunduguKat = Convert.ToInt32(cbBulunduguKat.SelectedItem);
                i.KatSayisi = Convert.ToInt32(cbBinadakiKatSayisi.SelectedItem);
                i.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                i.Isitma = cbIsitma.SelectedItem.ToString();
                i.Otopark = Convert.ToBoolean(chbOtopark.Checked);
                i.Guvenlik = Convert.ToBoolean(chbGuvenlik.Checked);
                i.YanginMerdiveni = Convert.ToBoolean(chbYanginMerdiveni.Checked);
                i.Jenarator = Convert.ToBoolean(chbJenerator.Checked);
                i.KabloTvUydu = Convert.ToBoolean(chbKabloTVUydu.Checked);
                i.TerasVeranda = Convert.ToBoolean(chbTerasVeranda.Checked);
                if (i.İlanGuncelleKontrol(i))
                {
                    MessageBox.Show("Bu konut önceden kayıtlı.", "Zaten Mevcut!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (i.IlanGuncelle(i))
                    {
                        MessageBox.Show("İlan güncellendi. ", "Güncelleme Başarılı !");
                        Temizle();
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        btnEkle.Enabled = true;
                        txtFiyat.Focus();

                    }

                    else { MessageBox.Show("Güncelleme gerçekleşmedi!!!", "Bir daha deneyin!!!"); }
                }
            }
            else { MessageBox.Show("(*) ile  işaretlenen alanları boş geçemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void btnAra_Click(object sender, EventArgs e)
        {

            frmAra frm = new frmAra();
            frm.ShowDialog();


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
    }
}
