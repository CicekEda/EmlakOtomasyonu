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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
            txtAdi.Focus();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cKullaniciGirisi kg = new cKullaniciGirisi();
            kg.KullaniciAdi = txtAdi.Text;
            kg.KullaniciSifre = txtSifre.Text;
            if (kg.KullaniciGiris(kg))
            {
                frmAnasayfa frm = new frmAnasayfa();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı", "Dikkat!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Temizle();
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSifre.Clear();
            txtAdi.Focus();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
