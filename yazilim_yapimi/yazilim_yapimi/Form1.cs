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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EH7GV89;Initial Catalog=yapimidata;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText="Select*From Kullanici_bilgi where kullanici_adi='"+text_kullanici.Text+"'And sifre='"+text_sifre.Text+"'";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                Form2 gecis = new Form2();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatali kullanici adi veya sifre");
            }
            con.Close();       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sifremiunuttum frm = new sifremiunuttum();
            frm.Show();
        }
    }
}
