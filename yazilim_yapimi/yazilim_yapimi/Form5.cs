using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace yazilim_yapimi
{
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EH7GV89;Initial Catalog=yapimidata;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_bilgi where kullanici_adi='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Form8 gecis = new Form8();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatali kullanici adi veya sifre");
            }
            con.Close();
        }
    }
}
