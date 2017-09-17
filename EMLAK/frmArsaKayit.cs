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
    public partial class frmArsaKayit : Form
    {
        public frmArsaKayit()
        {
            InitializeComponent();
        }


        cArsa ca = new cArsa();
        private void btnAra_Click(object sender, EventArgs e)
        {
            frmAra frm = new frmAra();
            frm.ShowDialog();
        }

        private void frmArsaKayit_Load(object sender, EventArgs e)
        {


            cMusteriSatici ms = new cMusteriSatici();
            ms.EmlakSahibiGetir(cbEmlakSahibi);

            txtIlanID.Text = cGenel.ilanID.ToString();
            cbEmlakSahibi.SelectedItem = cGenel.emlakSahibi;
            txtAdres.Text = cGenel.adres;
            txtil.Text = cGenel.il;
            txtFiyat.Text = cGenel.fiyat.ToString();
            dtpEklenmeTarihi.Text = cGenel.eklenmeTarihi;
            txtMetrekare.Text = cGenel.metrekare.ToString();

        }


        private void Temizle()
        {
            cbEmlakSahibi.SelectedIndex = -1;
            txtAdres.Clear();
            txtAciklama.Clear();
            txtBinaYuksekligi.Clear();
            txtBirimFiyati.Clear();
            txtFiyat.Clear();
            txtil.Clear();
            txtMetrekare.Clear();
            foreach (Control ctr in gbCevreOzellikleri.Controls)
            {
                ((CheckBox)ctr).Checked = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cbEmlakSahibi.SelectedIndex != -1 && txtAdres.Text != "" && txtFiyat.Text != "" && txtil.Text != "")
            {
                ca.EmlakSahibi= cbEmlakSahibi.SelectedItem.ToString();
                ca.Fiyat = Convert.ToDouble(txtFiyat.Text);
                ca.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                ca.Il = txtil.Text;
                ca.Adres = txtAdres.Text;
                ca.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                ca.Aciklama = txtAciklama.Text;
                ca.BirimmFiyat = Convert.ToDecimal(txtBirimFiyati.Text);
                ca.MaxBina = Convert.ToInt32(txtBinaYuksekligi.Text);
                ca.DenizManzarali = Convert.ToBoolean(chbDenizManzarali.Checked);
                ca.ElektrikHatti = Convert.ToBoolean(chbElektrikHatti.Checked);
                ca.Kanalizasyon = Convert.ToBoolean(chbKanalizasyon.Checked);
                ca.DogaManzarali = Convert.ToBoolean(chbDogaManzarali.Checked);
                ca.Parselli = Convert.ToBoolean(chbParselli.Checked);
                ca.YoluAcilmamis = Convert.ToBoolean(chbYoluAcilmamis.Checked);
                ca.Dogalgaz = Convert.ToBoolean(chbDogalgaz.Checked);
                ca.Imarli= Convert.ToBoolean(chbImarli.Checked);
                ca.Su = Convert.ToBoolean(chbSu.Checked);

                if (ca.ArsaKontrol(ca))
                {
                    MessageBox.Show("Bu konut önceden kaydedilmiştir!", "Zaten Var!");
                    cbEmlakSahibi.Focus();
                }
                else
                {
                    if (ca.ArsaEkle(ca))
                    {
                        MessageBox.Show("Müşteri kayıt işlemi gerçekleştirildi!", "KAYIT EDİLDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbEmlakSahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmlakSahibi.SelectedIndex==-1)
            {
                txtIlanID.Text = "0";
            }
            else
            {
                ca.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                txtIlanID.Text = ca.ArsaIDGetir().ToString();
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    bool Sonuc = Convert.ToBoolean(ca.ArsaSil(Convert.ToInt32(txtIlanID.Text)));
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
            catch (Exception hata)
            {
                string Mesaj = hata.Message;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbEmlakSahibi.SelectedItem.ToString()) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtil.Text))
            {
                MessageBox.Show("(*) ile  işaretlenen alanları boş geçemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbEmlakSahibi.Focus();
            }
            else
            {
                ca.EmlakSahibi = cbEmlakSahibi.SelectedItem.ToString();
                ca.Fiyat = Convert.ToDouble(txtFiyat.Text);
                ca.Metrekare = Convert.ToInt32(txtMetrekare.Text);
                ca.Il = txtil.Text;
                ca.Adres = txtAdres.Text;
                ca.EklenmeTarihi = dtpEklenmeTarihi.Value.ToShortDateString();
                ca.Aciklama = txtAciklama.Text;
                ca.BirimmFiyat = Convert.ToDecimal(txtBirimFiyati.Text);
                ca.MaxBina = Convert.ToInt32(txtBinaYuksekligi.Text);
                ca.DenizManzarali = Convert.ToBoolean(chbDenizManzarali.Checked);
                ca.ElektrikHatti = Convert.ToBoolean(chbElektrikHatti.Checked);
                ca.Kanalizasyon = Convert.ToBoolean(chbKanalizasyon.Checked);
                ca.DogaManzarali = Convert.ToBoolean(chbDogaManzarali.Checked);
                ca.Parselli = Convert.ToBoolean(chbParselli.Checked);
                ca.YoluAcilmamis = Convert.ToBoolean(chbYoluAcilmamis.Checked);
                ca.Dogalgaz = Convert.ToBoolean(chbDogalgaz.Checked);
                ca.Imarli = Convert.ToBoolean(chbImarli.Checked);
                ca.Su = Convert.ToBoolean(chbSu.Checked);
                ca.IlanID = Convert.ToInt32(txtIlanID.Text);

                if (ca.ArsaKontrolByGuncelle(ca))
                {
                    MessageBox.Show("Bu konut önceden kayıtlı.", "Zaten Mevcut!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbEmlakSahibi.Focus();
                }
                else
                {
                    if (ca.ArsaGuncelle(ca))
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

        private void btnEmlakSahibiGit_Click(object sender, EventArgs e)
        {
            frmMusteriSatici frm = new frmMusteriSatici();
            frm.ShowDialog();
            cMusteriSatici ms = new cMusteriSatici();
            cbEmlakSahibi.Items.Clear();
            ms.EmlakSahibiGetir(cbEmlakSahibi);
        }
    }
}
