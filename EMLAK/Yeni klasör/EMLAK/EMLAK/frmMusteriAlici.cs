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
    public partial class frmMusteriAlici : Form
    {
        public frmMusteriAlici()
        {
            InitializeComponent();
        }
        cMusteriAlici ma = new cMusteriAlici();
        SqlConnection conn = new SqlConnection(cGenel.connStr);
        //DataSet ds = new DataSet();
        //DataTable dt = new DataTable();
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
            Temizle();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            mtxtTelefon.Clear();
            txtMail.Clear();
            txtAciklama.Clear();
            cbKategori.SelectedIndex = -1;
            cbIslemTuru.SelectedIndex = -1;
            txtAdi.Focus();
        }
  
        private void frmMusteriAlici_Load(object sender, EventArgs e)
        {
            dgvMusteriAliciKayit.DataSource = ma.MusteriAliciGoster();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && mtxtTelefon.Text.Trim() != "")
            {
                cMusteriAlici ma = new cMusteriAlici();
                ma.MusteriAliciAd = txtAdi.Text;
                ma.MusteriAliciSoyad = txtSoyadi.Text;
                ma.Telefon = mtxtTelefon.Text;
                ma.Mail = txtMail.Text;
                ma.Aciklama = txtAciklama.Text;
                ma.IslemTarihi = dtpIslemTarihi.Value.ToShortDateString();
                ma.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                ma.Kategori = cbKategori.SelectedItem.ToString();
                if (ma.MusteriAliciVarMi(ma))
                {
                    MessageBox.Show("Müşteri Kayıtlarımızda mevcut.", "Zaten kayıtlı!!!");
                    txtAdi.Focus();
                }
                else
                {
                    if (ma.MusteriAliciEkle(ma))
                    {
                        MessageBox.Show("Müşteri eklendi.", "Kayıt başarıyla eklendi.");
                        dgvMusteriAliciKayit.DataSource = ma.MusteriAliciGoster();
                        Temizle();
                        txtAdi.Focus();
                        btnEkle.Enabled = false;
                        //SqlDataAdapter da = new SqlDataAdapter("Select * from MusteriAlici where Silindi=0", conn);
                        //dgvMusteriAliciKayit.DataSource = dt;

                    }
                    else { MessageBox.Show("Kayıt gerçekleşmedi", "Bir daha kontrol ederek deneyin!"); }
                }


            }
            else { MessageBox.Show("Ad,Soyad,Telefon boş bırakılmamalıdır. ", "Dikkat !! Eksik bilgi !!!"); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || string.IsNullOrEmpty(mtxtTelefon.Text))
            {
                MessageBox.Show("Öncelikle Ad , Soyad ,Telefon bilgileri girilmelidir.", "Eksik Bilgi!!!");
            }
            else
            {
                cMusteriAlici ma = new cMusteriAlici();

                ma.MusteriAliciID = Convert.ToInt32(txtMusteriAliciID.Text);
                ma.MusteriAliciAd = txtAdi.Text;
                ma.MusteriAliciSoyad = txtSoyadi.Text;
                ma.Telefon = mtxtTelefon.Text;
                ma.Mail = txtMail.Text;
                ma.IslemTuru = cbIslemTuru.SelectedItem.ToString();
                ma.Kategori = cbKategori.SelectedItem.ToString();
                ma.Aciklama = txtAciklama.Text;

                ma.IslemTarihi = dtpIslemTarihi.Value.ToString();


                if (ma.MusteriAliciVarMiByGuncelle(ma))
                {
                    MessageBox.Show("Müşteri Kayıtlarımızda mevcut.", "Zaten kayıtlı!!!");
                }
                else
                {


                    if (ma.MusteriAliciGuncelle(ma))
                    {
                        MessageBox.Show("Müşteri bilgileri güncellendi.", "Güncellendi!!!");
                        dgvMusteriAliciKayit.DataSource = ma.MusteriAliciGoster();
                        Temizle();
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;

                    }
                    else
                    { MessageBox.Show("Güncelleştirme Gerçekleşmedi!!!", "DİKKAT!!!"); }
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cMusteriAlici ma = new cMusteriAlici();

                bool Sonuc = Convert.ToBoolean(ma.MusteriAliciSil(Convert.ToInt32(txtMusteriAliciID.Text)));
                if (Sonuc)
                {
                    MessageBox.Show("Müşteri bilgileri silindi.");
                    dgvMusteriAliciKayit.DataSource = ma.MusteriAliciGoster();
                    Temizle();
                    btnTemizle.Enabled = false;
                    btnSil.Enabled = false;
                }
                else { MessageBox.Show("Silme gerçekleşmedi!"); txtAdi.Focus(); }
            }


        }



        private void dgvMusteriAliciKayit_DoubleClick(object sender, EventArgs e)
        {
          
           
            txtMusteriAliciID.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[0].Value.ToString();
            txtAdi.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyadi.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[2].Value.ToString();
            mtxtTelefon.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[3].Value.ToString();
            txtMail.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[4].Value.ToString();
            dtpIslemTarihi.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[5].Value.ToString();
            txtAciklama.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[6].Value.ToString();
            cbIslemTuru.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[8].Value.ToString();
            cbKategori.Text = dgvMusteriAliciKayit.SelectedRows[0].Cells[9].Value.ToString();
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }
    }
}
