
namespace yazilim_yapimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_giris = new System.Windows.Forms.Button();
            this.text_kullanici = new System.Windows.Forms.TextBox();
            this.text_sifre = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(328, 205);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "GIRIS";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // text_kullanici
            // 
            this.text_kullanici.Location = new System.Drawing.Point(328, 60);
            this.text_kullanici.Name = "text_kullanici";
            this.text_kullanici.Size = new System.Drawing.Size(100, 22);
            this.text_kullanici.TabIndex = 1;
            this.text_kullanici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_sifre
            // 
            this.text_sifre.Location = new System.Drawing.Point(328, 122);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(100, 22);
            this.text_sifre.TabIndex = 2;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.AutoSize = true;
            this.kullanici_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi.Location = new System.Drawing.Point(151, 60);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(111, 16);
            this.kullanici_adi.TabIndex = 3;
            this.kullanici_adi.Text = "KULLANICI ADI";
            this.kullanici_adi.Click += new System.EventHandler(this.label1_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(151, 122);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(51, 16);
            this.sifre.TabIndex = 4;
            this.sifre.Text = "SIFRE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(325, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SIFREMI UNUTTUM";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.text_sifre);
            this.Controls.Add(this.text_kullanici);
            this.Controls.Add(this.btn_giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox text_kullanici;
        private System.Windows.Forms.TextBox text_sifre;
        private System.Windows.Forms.Label kullanici_adi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

