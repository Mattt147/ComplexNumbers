using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Form1 f1;
        private void Dekart_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Show();

        }
        Polar f2;
        private void Polar_Click(object sender, EventArgs e)
        {
            f2 = new Polar();
            f2.Show();

        }
        Exp f3;
        private void Exp_Click(object sender, EventArgs e)
        {
            f3 = new Exp();
            f3.Show();

        }
    }
}
