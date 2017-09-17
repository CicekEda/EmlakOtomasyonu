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

            if (cbİslemTuru.SelectedItem.ToString() != "")
            {
                IslemTuru = cbİslemTuru.SelectedItem.ToString();


                if ((IslemTuru == "İşyeri  - Kiralık") || (IslemTuru == "İşyeri - Satılık"))
                {
                    cIsyeri isyeri = new cIsyeri();
                    dt = isyeri.IlanlarıGoster(IslemTuru, Convert.ToDouble(txtMinFiyat.Text), Convert.ToDouble(txtMaxFiyat.Text), Convert.ToInt32(txtMinMetrekare.Text), Convert.ToInt32(txtMaxMetrekare.Text), txtil.Text);
                    dgvAra.DataSource = dt;
                }
                else if (IslemTuru == "Konut - Kiralık" || IslemTuru == "Konut - Satılık")
                {
                    cKonut k = new cKonut();
                    dt = k.KonutGosterByAra(Convert.ToDouble(txtMinFiyat.Text), Convert.ToDouble(txtMaxFiyat.Text), Convert.ToInt32(txtMinMetrekare.Text), Convert.ToInt32(txtMaxMetrekare.Text), IslemTuru, txtil.Text);
                    dgvAra.DataSource = dt;
                }
                else
                {
                    cArsa a = new cArsa();
                    dt = a.ArsaGoster(IslemTuru, Convert.ToDouble(txtMinFiyat.Text), Convert.ToDouble(txtMaxFiyat.Text), Convert.ToInt32(txtMinMetrekare.Text), Convert.ToInt32(txtMaxMetrekare.Text), txtil.Text);
                    dgvAra.DataSource = dt;

                }
            }
        }


        private void dgvAra_DoubleClick(object sender, EventArgs e)
        {
            string IslemTuru = "";

            if (cbİslemTuru.SelectedItem.ToString() != "")
            {
                IslemTuru = cbİslemTuru.SelectedItem.ToString();


                if ((IslemTuru == "İşyeri  - Kiralık") || (IslemTuru == "İşyeri - Satılık"))
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

                    frmIsyeriKayit isyeri = new frmIsyeriKayit();

                    isyeri.ShowDialog();
                }
                else if (IslemTuru == "Konut - Kiralık" || IslemTuru == "Konut - Satılık")
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

                    frmKonutKayit konut = new frmKonutKayit();
                    konut.ShowDialog();
                }
                else
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

                    frmArsaKayit arsa = new frmArsaKayit();
                    arsa.ShowDialog();

                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            IlanAra();
        }
    }
}