﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo
{
    public partial class MasterJadwal : Form
    {
        public MasterJadwal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterKodePromo from = new MasterKodePromo();
            from.ShowDialog();
        }
    }
}
