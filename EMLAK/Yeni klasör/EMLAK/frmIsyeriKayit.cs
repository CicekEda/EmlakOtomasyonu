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
        {   cMusteriSatici m = new cMusteriSatici();
            m.MusteriSaticiGoster(cbEmlakSahibi);


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
                i.BulunduguKat = cbBulunduguKat.SelectedItem.ToString();
                i.KatSayisi = cbBinadakiKatSayisi.SelectedItem.ToString();
                //i.Fotograf = pbfotograf.ToString();
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
                        MessageBox.Show("İlan eklendi. ", "Kayıt Başarılı !");
                        Temizle();
                        txtFiyat.Focus();
                    
                    }

                    else { MessageBox.Show("Kayıt gerçekleşmedi!!!", "Bir daha deneyin!!!"); }
                }
            }
            else { MessageBox.Show("Fiyat , İl , Adres , Metrekare bilgileri eksik girilmemelidir.", "Dikkat eksik bilgi!!"); }
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
            ms.MusteriSaticiGoster(cbEmlakSahibi);
        }

   

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cIsyeri i = new cIsyeri();

                bool Sonuc = Convert.ToBoolean(i.IlanSil(Convert.ToInt32(txtIlanID.Text)));
                if (Sonuc)
                {
                    MessageBox.Show("İlan bilgileri silindi.");
                   
                    Temizle();
                    btnTemizle.Enabled = false;
                    btnSil.Enabled = false;
                }
                else { MessageBox.Show("Silme gerçekleşmedi!"); txtFiyat.Focus(); }
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
                i.BulunduguKat = cbBulunduguKat.SelectedItem.ToString();
                i.KatSayisi = cbBinadakiKatSayisi.SelectedItem.ToString();
                //i.Fotograf = pbfotograf.ToString();
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
                    MessageBox.Show("ilan Kayıtlarımızda mevcut.", "Zaten kayıtlı!!!");
                }
                else
                {
                    if (i.IlanGuncelle(i))
                    {
                        MessageBox.Show("İlan güncellendi. ", "Güncelleme Başarılı !");
                        Temizle();
                        txtFiyat.Focus();

                    }

                    else { MessageBox.Show("Güncelleme gerçekleşmedi!!!", "Bir daha deneyin!!!"); }
                }
            }
            else { MessageBox.Show("Fiyat , İl , Adres , İslem türü , Emlak Sahibi bilgileri eksik girilmemelidir.", "Dikkat eksik bilgi!!"); }
        }
        

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmAra ara = new EMLAK.frmAra();
            ara.Show();


        }

   
        private void pbIs1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya1 = new OpenFileDialog();
            dosya1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya1.ShowDialog();
            string dosyayolu1 = dosya1.FileName;
            pbIs1.ImageLocation = dosyayolu1;
        }

        private void pbIs2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya2 = new OpenFileDialog();
            dosya2.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya2.ShowDialog();
            string dosyayolu2 = dosya2.FileName;
            pbIs2.ImageLocation = dosyayolu2;
        }

        private void pbIs3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya3 = new OpenFileDialog();
            dosya3.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya3.ShowDialog();
            string dosyayolu3 = dosya3.FileName;

            pbIs3.ImageLocation = dosyayolu3;
        }

        private void pbIs4_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya4 = new OpenFileDialog();
            dosya4.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya4.ShowDialog();



            string dosyayolu4 = dosya4.FileName;



            pbIs4.ImageLocation = dosyayolu4;
        }
    }
}
