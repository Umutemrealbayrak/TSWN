using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace yazilim_yapimi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        string resimadres;
        public void sorual()
        {
            ofdResim.Title = "soru seç";
            ofdResim.Filter = "Jpeg Dosyaları(.jpg)|.jpg|Gif dosyalari(.gif)|.gif";

        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-EH7GV89;Initial Catalog=soru;Integrated Security=True");

        private void egitmensoru_Load(object sender, EventArgs e)
        {
            sorual();

        }

        private void btn_soru_Click_1(object sender, EventArgs e)
        {
            ofdResim.ShowDialog();
            pictureBox1.ImageLocation = ofdResim.FileName;
            resimadres = ofdResim.FileName;
        }


        private void kaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO  Table_6 (resim) VALUES (@p1)", bgl);
            bgl.Open();
            cmd.Parameters.AddWithValue("@p1", resimadres);

            int cm = cmd.ExecuteNonQuery();
            if (cm != 0)
            {
                bgl.Close();
            }
        }

        
    }
}
