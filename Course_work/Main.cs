using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_work
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client Exercise2 = new Client();
            Exercise2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("IS-4103 Bondar M.I.\nSportcomplex.");
        }
    }
}
