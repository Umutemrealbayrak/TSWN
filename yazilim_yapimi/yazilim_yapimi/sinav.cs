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
using System.Data.Sql;
using System.Data.SqlTypes;

namespace yazilim_yapimi
{
    public partial class sinav : Form
    {
        public sinav()
        {
            InitializeComponent();
        }
        SqlConnection conResim;
        
        
        private void sinav_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'soruDataSet6.Table_6' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_6TableAdapter.Fill(this.soruDataSet6.Table_6);
            // TODO: Bu kod satırı 'soruDataSet4.Table_4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.table_5TableAdapter1.Fill(this.soruDataSet51.Table_5);
            
            

            
        }
        int SORUID;
        string sorucevap;
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-EH7GV89;Initial Catalog=soru;Integrated Security=True");
        int sayac = 60;
        int dogru = 0, yanlis = 0;
        public void sonuclar(RadioButton seciliolan)
        {
            if (seciliolan.Checked == true)
            {
                dogru++;
            }
            else
            {
                yanlis++;
            }
            label7.Text = dogru.ToString();
            label5.Text = yanlis.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac--;
            label8.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz dolmuştur");
                sonuclar(A);
              /*  for (int i = 0; i < 3; i++)
                {
                    sonuclar(sonuclar());
                }
                sonuclar(B);
                sonuclar(D);
                sonuclar(C);
                sonuclar(B);
                sonuclar(A);
                sonuclar(C);
                sonuclar(B);
                sonuclar(A);
                sonuclar(D);*/


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilen = dataGridView1.SelectedCells[0].RowIndex;
            //pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            //SORUID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
//            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SORUID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_6 Where id=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", SORUID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string a= Convert.ToString(reader[0]);
                pictureBox1.ImageLocation = Convert.ToString(reader[1]);
                bgl.Close();
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {


            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_6 Where id=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", SORUID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string a = Convert.ToString(reader[0]);
                pictureBox1.ImageLocation = Convert.ToString(reader[1]);
                bgl.Close();
            }
            if (textBox1.Text == sorucevap)
            {
                MessageBox.Show("yanlış");
            }
            else
            {
                MessageBox.Show("dogru");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           // sonuclar(A);
         
        }
    }  
    }


 

