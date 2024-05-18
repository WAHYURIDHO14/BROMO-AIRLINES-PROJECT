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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkun form = new DaftarAkun();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.ShowDialog();
        }
    }
}
