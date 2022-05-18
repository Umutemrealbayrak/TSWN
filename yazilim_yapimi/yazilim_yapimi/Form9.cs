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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 orm=new Form3();
            orm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form0 form=new Form0();
            form.Show();
            this.Hide();
        }
    }
}
