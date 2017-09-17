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
    public partial class frmMusteriSatici : Form
    {
        public frmMusteriSatici()
        {
            InitializeComponent();
        }

        private void frmMusteriSatici_Load(object sender, EventArgs e)
        {
            cMusteriSatici cm = new cMusteriSatici();
            dgvMusteriSatici.DataSource = cm.MusteriSaticiGoster();
        }
        private void btnEkle_Click_1(object sender, EventArgs e) 
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && mtxtTelefon.Text.Trim() != "")
            {
                cMusteriSatici ms = new cMusteriSatici();

                ms.MusteriSaticiAd = txtAdi.Text;
                ms.MusteriSaticiSoyad = txtSoyadi.Text;
                ms.Telefon = mtxtTelefon.Text;
                ms.Mail = txtMail.Text;

                if (ms.MusteriSaticiKontrol(ms))
                {
                    MessageBox.Show("Bu müşteri zaten kayıtlı.");
                    txtAdi.Focus();
                }
                else
                {
                    if (ms.MusteriSaticiEkle(ms))
                    {
                        MessageBox.Show("Müşteri kayıt işlemi gerçekleştirildi!", "KAYIT EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                        dgvMusteriSatici.DataSource = ms.MusteriSaticiGoster();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt gerçekleştirilemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Emlak Sahibi adı, soyadı ve telefonu boş geçemezsiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdi.Focus();
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void dgvMusteriSatici_DoubleClick(object sender, EventArgs e)
        {
            txtMusteriSaticiID.Text = dgvMusteriSatici.SelectedRows[0].Cells[0].Value.ToString();
            txtAdi.Text = dgvMusteriSatici.SelectedRows[0].Cells[1].Value.ToString();
            txtSoyadi.Text = dgvMusteriSatici.SelectedRows[0].Cells[2].Value.ToString();
            mtxtTelefon.Text = dgvMusteriSatici.SelectedRows[0].Cells[3].Value.ToString();
            txtMail.Text = dgvMusteriSatici.SelectedRows[0].Cells[4].Value.ToString();
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
            btnEkle.Enabled = false;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek istiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cMusteriSatici ms = new cMusteriSatici();
                    bool Sonuc = Convert.ToBoolean(ms.MusteriSaticiSil(Convert.ToInt32(txtMusteriSaticiID.Text)));
                    if (Sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri silindi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvMusteriSatici.DataSource = ms.MusteriSaticiGoster();
                        Temizle();
                        btnEkle.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Silme gerçekleşmedi!", "  HATA !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException hata)
            {
                string mesaj = hata.Message;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || string.IsNullOrEmpty(mtxtTelefon.Text))
            {
                MessageBox.Show("Emlak Sahibi adı, soyadı ve telefonu boş geçemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdi.Focus();
            }
            else
            {
                cMusteriSatici ms = new cMusteriSatici();
                ms.MusteriSaticiID = Convert.ToInt32(txtMusteriSaticiID.Text);
                ms.MusteriSaticiAd = txtAdi.Text;
                ms.MusteriSaticiSoyad = txtSoyadi.Text;
                ms.Telefon = mtxtTelefon.Text;
                ms.Mail = txtMail.Text;
                if (ms.MusteriKontrolByGuncelle(ms))
                {
                    MessageBox.Show("Bu emlak sahibi önceden kayıtlı.", "Zaten Mevcut!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdi.Focus();
                }
                else
                {
                    if (ms.MusteriGuncelle(ms))
                    {
                        MessageBox.Show("Emlak sahibi güncellendi.", "Değişiklik Gerçekleştirildi.");
                        dgvMusteriSatici.DataSource = ms.MusteriSaticiGoster();
                        Temizle();
                        btnGuncelle.Enabled = false;
                        btnSil.Enabled = false;
                        btnEkle.Enabled = true;
                        txtAdi.Focus();
                    }
                    else { MessageBox.Show("Güncelleme gerçekleşmedi!"); txtAdi.Focus(); }
                }
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtMail.Clear();
            mtxtTelefon.Clear();
            txtMusteriSaticiID.Clear();
            btnEkle.Enabled = true;
            txtAdi.Focus();
        }

    }
}
