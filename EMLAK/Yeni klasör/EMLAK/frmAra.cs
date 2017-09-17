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
    public partial class frmAra : Form
    {
        public frmAra()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void IlanAra()
        {
            string IslemTuru = "";
            if (cbİslemTuru.SelectedItem.ToString() != "Tüm Türler")
            {
                IslemTuru = cbİslemTuru.SelectedItem.ToString();
          
                if (cbİslemTuru.SelectedItem.ToString() == "İşyeri  - Kiralık" || cbİslemTuru.SelectedItem.ToString() == "İşyeri - Satılık")
                {
                    cIsyeri isyeri = new cIsyeri();
                 dt=isyeri.IlanlarıGoster(txtEmlakSahibi.Text, IslemTuru, Convert.ToDouble(txtMinFiyat.Text), Convert.ToDouble(txtMaxFiyat.Text), Convert.ToInt32(txtMinMetrekare.Text), Convert.ToInt32(txtMaxMetrekare.Text), txtil.Text, dgvAra);
                dgvAra.DataSource = dt;
  }
                }
           


        }

        private void txtEmlakSahibi_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void txtMinFiyat_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void txtMaxFiyat_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void txtMinMetrekare_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void txtMaxMetrekare_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void cbİslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void txtil_TextChanged(object sender, EventArgs e)
        {
            IlanAra();
        }

        private void dgvAra_DoubleClick(object sender, EventArgs e)
        {
            cGenel.ilanID = Convert.ToInt32(dgvAra.SelectedRows[0].Cells["IlanID"].Value);
            cGenel.emlakSahibi = dgvAra.SelectedRows[0].Cells["EmlakSahibi"].Value.ToString();
            cGenel.islemTuru = dgvAra.SelectedRows[0].Cells["IslemTuru"].Value.ToString();
            cGenel.il = dgvAra.SelectedRows[0].Cells["Il"].Value.ToString();
            cGenel.adres = dgvAra.SelectedRows[0].Cells["Adres"].Value.ToString();
            cGenel.fiyat = Convert.ToDouble(dgvAra.SelectedRows[0].Cells["Fiyat"].Value);
            cGenel.metrekare = Convert.ToInt32(dgvAra.SelectedRows[0].Cells["Metrekare"].Value);
            cGenel.eklenmeTarihi = dgvAra.SelectedRows[0].Cells["EklenmeTarihi"].Value.ToString();
            this.Close();
            frmIsyeriKayit i = new frmIsyeriKayit();

            i.ShowDialog();
        }

        private void frmAra_Load(object sender, EventArgs e)
        {
         
            cbİslemTuru .Items.Insert(0, "Tüm Türler");
            cbİslemTuru .SelectedIndex = 0;
            List<cIsyeriModel> liste = new List<cIsyeriModel>();
            cIsyeriModel im = new cIsyeriModel();
            liste = im.IsyeriGosterByAra();
            int i = 0;
            foreach (cIsyeriModel isyeri in liste)
            {
                lvAra.Items.Add(isyeri.IlanID.ToString());
                lvAra.Items[i].SubItems.Add(isyeri.EmlakSahibi);
                lvAra.Items[i].SubItems.Add(isyeri.IslemTuru);
                lvAra.Items[i].SubItems.Add(isyeri.Il);
                lvAra.Items[i].SubItems.Add(isyeri.Adres);
                lvAra.Items[i].SubItems.Add(isyeri.Fiyat.ToString());
                lvAra.Items[i].SubItems.Add(isyeri.Metrekare.ToString());
                lvAra.Items[i].SubItems.Add(isyeri.EklenmeTarihi);
                i++;
            }
            dgvAra.DataSource = liste;


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            IlanAra();
        }


    }
}