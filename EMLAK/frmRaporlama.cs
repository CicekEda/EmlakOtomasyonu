﻿using System;
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
    public partial class frmRaporlama : Form
    {
        public frmRaporlama()
        {
            InitializeComponent();
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.EmlakSatis' table. You can move, or remove it, as needed.
            this.EmlakSatisTableAdapter.Fill(this.DataSet1.EmlakSatis);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EmlakSatisTableAdapter.FillBy(this.DataSet1.EmlakSatis,txtEmlakSahibi.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.EmlakSatisTableAdapter.FillBy1(this.DataSet1.EmlakSatis,txtEmlakTuru.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
