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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 from = new Form1();
            from.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeliTiket from = new BeliTiket();
            from.ShowDialog();
        }
    }
}
