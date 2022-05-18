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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EH7GV89;Initial Catalog=yapimidata;Integrated Security=True");

        private void kayit_Click(object sender, EventArgs e)
        {



            string ekle;

            ekle = "INSERT INTO Kullanici_bilgi (kullanici_adi,sifre) " +
            "VALUES ('" + kullaniciadi.Text + "','" + sifre.Text + "')";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(ekle, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("kaydedildi");
            baglanti.Close();



        }
    }
}
