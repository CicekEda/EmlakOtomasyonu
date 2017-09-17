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


            cMusteriSatici m = new cMusteriSatici();
            m.MusteriSaticiGoster(cbEmlakSahibi);
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
        }

   

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtil.Text) || string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtMetrekare.Text)) 
            {
                MessageBox.Show("Fiyat , İl , Adres , Metrekare bilgileri eksik girilmemelidir.", "Dikkat eksik bilgi!!");
            }
            //else
            //{
            //    cIsyeri i = new cIsyeri();
            //    i.IlanID=

            //}
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmAra ara = new EMLAK.frmAra();
            ara.Show();


            cbEmlakSahibi.SelectedItem = cGenel.EmlakSahibi;
            cbIslemTuru.SelectedItem = cGenel.IslemTuru;
            txtMetrekare.Text  = (cGenel.Metrekare).ToString ();
            txtil.Text = cGenel.Il;
            txtAdres.Text = cGenel.Adres;
            txtFiyat.Text =( cGenel.Fiyat).ToString();
            dtpEklenmeTarihi.Text = cGenel.EklenmeTarihi;
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
