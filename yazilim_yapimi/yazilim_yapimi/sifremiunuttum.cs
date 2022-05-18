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
using System.Net.Mail;

namespace yazilim_yapimi
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("Mail Adresiniz.");
            ePosta.To.Add(textBox1.Text);

            ePosta.Subject = konu;
            ePosta.Body = icerik;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("Mail Adresiniz.", "Mail Şifreniz.");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }
        string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EH7GV89;Initial Catalog=yapimidata Security=True");
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    SqlCommand komut = new SqlCommand("select * from Kullanici_bilgi where ePosta='" + textBox1.Text + "'");
                    komut.Connection = baglanti;
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        sifre = oku["ePosta"].ToString();

                        label2.Visible = true;
                        label2.ForeColor = Color.Green;
                        label2.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";

                        progressBar1.Visible = true;
                        progressBar1.Maximum = 900000;
                        progressBar1.Minimum = 90;

                        for (int j = 90; j < 900000; j++)
                        {
                            progressBar1.Value = j;
                        }

                        MailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
                        baglanti.Close();
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.ForeColor = Color.Red;
                        label2.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                    }
                }
                catch (Exception)
                {
                    label2.Visible = true;
                    label2.ForeColor = Color.Red;
                    label2.Text = "Mail Gönderme Hatası";
                }

            }

      



    }
}
