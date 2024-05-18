using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }
    }
}
