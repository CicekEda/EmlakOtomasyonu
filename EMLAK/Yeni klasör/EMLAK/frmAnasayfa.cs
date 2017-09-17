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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void konutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKonutKayit frm = new EMLAK.frmKonutKayit();

            FormAcikmi(frm);
        }

        private void işyeriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriKayit frm = new frmIsyeriKayit();
            FormAcikmi(frm);
        }

        private void arsaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmArsaKayit frm = new EMLAK.frmArsaKayit();
            FormAcikmi(frm);
        }

        private void satıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriSatici frm = new EMLAK.frmMusteriSatici();
            FormAcikmi(frm);
        }

        private void alıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriAlici frm = new frmMusteriAlici();
            FormAcikmi(frm);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAra frm = new frmAra();
            FormAcikmi(frm);
        }

        private void rAPORLAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
            FormAcikmi(frm);
        }
        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); //form nesnesi hafızadan atılır.
            }
        }
    }
}
