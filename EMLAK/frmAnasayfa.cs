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

            
            frm.ShowDialog();

        }
        

        private void işyeriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriKayit frm = new frmIsyeriKayit();
          
            frm.ShowDialog();
        }

        private void arsaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArsaKayit frm = new EMLAK.frmArsaKayit();
           
            frm.ShowDialog();
        }

     
        private void satıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriSatici frm = new EMLAK.frmMusteriSatici();
          
            frm.ShowDialog();
        }

        private void alıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriAlici frm = new frmMusteriAlici();
          
            frm.ShowDialog();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAra frm = new frmAra();
          
            frm.ShowDialog();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRaporlama frm = new frmRaporlama();
          
            frm.ShowDialog();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
