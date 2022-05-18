using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_yapimi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void kullanicigiris_Click(object sender, EventArgs e)
        {
            Form1 form2sec = new Form1();
            form2sec.Show();
            this.Hide();

        }

        private void admingirisi_Click(object sender, EventArgs e)
        {
            Form4 form2sec = new Form4();
            form2sec.Show();
            this.Hide();
        }

        private void sinavsorumlusugiris_Click(object sender, EventArgs e)
        {
            Form5 form2sec = new Form5();
            form2sec.Show();
            this.Hide();
        }
    }
}
