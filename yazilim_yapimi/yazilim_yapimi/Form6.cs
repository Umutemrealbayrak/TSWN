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
    public partial class Form6 : Form
    {
        string resimAdresi; /* OpenFileDialog kontrolünden seçtigimiz dosyanin tam adresini tutacak genel bir degisken. */

        /* Bu metodumuzda OpenFileDialog kontrolümüzün temel ayarlarini yapiyoruz. */

        public void DialogHazirla()
        {
            ofdResim.Title = "Duvar Kagidini Seç"; /* Dosya açma iletisim kutumuzun basligini belirliyoruz. */

            ofdResim.Filter = "Jpeg Dosyalari(*.jpg)|*.jpg|Gif dosyalari(*.gif)|*.gif"; /* Iletisim kutumuzun, sadece jpg ve gif dosyalarini göstermesini, Filter özelligi ile ayarliyoruz.*/
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            DialogHazirla();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            /* Kullanici bu butona tikladiginda, OpenFileDialog kontrolümüz, dosya açma iletisim kutusunu açar. Kullanici bir dosya seçip OK tusunda bastiginda, Picture Box kontrolümüze seçilen resim dosyasi alinarak gösterilmesi sağlanır. Daha sonra seçilen dosyanin tam adresi label kontrolümüze alınır ve resimAdresi degiskenimize atanır. */

            if (ofdResim.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(ofdResim.FileName); /* Drawing isim uzayinda yer alan Image sinifinin FromFile metodunu kullanarak belirtilen adresteki dosya PictureBox kontrolü içine çizilir. */

                richTextBox1.Text = ofdResim.FileName.ToString();
                resimAdresi = ofdResim.FileName.ToString();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            /* Simdi en önemli kodlarimizi yazmaya basliyoruz. Öncelikle dosyamizi açmamiz gerekli. Çünkü resim dosyasinin içerigini byte olarak okumak istiyoruz. Bu amaçla FileStream nesnemizi olusturuyor ve gerekli parametrelerini ayarliyoruz. Ilk parametre, dosyanin tam yolunu belirtir. Ikinci parametre ise dosyamizi açmak için kullanacagimizi belirtir. Son parametre ise dosyanin okuma amaci ile açildigini belirtir. */

            FileStream fsResim = new FileStream(resimAdresi, FileMode.Open, FileAccess.Read);

            /* BinaryReader nesnemiz, byte dizimiz ile, parametre olarak aldigi FileStream nesnesi arasinda , veri akisini saglamak için olusturuluyor. Akim, FileStream nesnesinin belirttigi dosyadan, dosyadaki byte'larin aktarilacagi diziye dogru olucaktir.*/

            BinaryReader brResim = new BinaryReader(fsResim);

            /* Simdi resim adinda bir byte dizisi olusturuyoruz. brResim isimli BinaryReader nesnemizin, ReadBytes metodunu kullanarak, bu nesnenin veri akisi için baglanti kurdugu FileStream nesnesinin belirttigi dosyadaki tüm byte'lari, byte dizimize akitiyoruz. Böylece resim dosyamizin tüm byte'lari yani dosyamizin kendisi, byte dizimize aktarilmis oluyor.*/

            byte[] resim = brResim.ReadBytes((int)fsResim.Length);
            /* Son olarak, BinaryReader ve FileStream nesnelerini kapatiyoruz. */
            brResim.Close();
            fsResim.Close();
            /* Artik Sql baglantimizi olusturabilir ve sql komutumuzu çalistirabiliriz. Önce SqlConnection nesnemizi olusturuyoruz. */

            SqlConnection conResim = new SqlConnection("data source=DESKTOP-EH7GV89;initial catalog=soru;integrated security=sspi");
            

            /* Simdi sql komutumuzu çalistiracak olan SqlCommand nesnemizi olusturuyoruz. Burada alanlarin degerlerini parametreler üzerinden aktardigimiza dikkat edelim. */

            SqlCommand cmdResimKaydet = new SqlCommand("insert into Table_2 (soru_metin,soru_resim) values (soru_metin,soru_resim)", conResim);
            cmdResimKaydet.Parameters.Add("@soru_metin", SqlDbType.Char, 250).Value = richTextBox1.Text; /* Bu parametremiz @Yorum isminde ve Char tipinde. 250 karakter uzunlugunda. Hemen ayni satirda Value özelligini kullanarak parametrenin degerinide belirliyoruz. */
            cmdResimKaydet.Parameters.Add("@soru_resim", SqlDbType.Image, resim.Length).Value = resim; /* Seçtigimiz resim dosyasinin byte'larini, tablodaki ilgili alana tasiyacak parametremizi belirtiyoruz. Deger olarak, resim isimli byte dizimizi aktariyoruz. Parametre tipinin, image olduguna dikkat edelim. */


            /* Günveli blogumuzda, Sql baglantimizi açiyoruz. Ardindan, sql komutumuzu ExecuteNonQuery metodu ile çalistiriyoruz. Son olarakta herhangibir hata olsada, olmasada, finally blogunda sql baglantimizi kapatiyoruz.*/

            try
            {
                conResim.Open();
                cmdResimKaydet.ExecuteNonQuery();
                MessageBox.Show(richTextBox1.Text + " Tabloya Basarili Bir Sekilde Kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                conResim.Close();
            }
        }

        
    }
}

