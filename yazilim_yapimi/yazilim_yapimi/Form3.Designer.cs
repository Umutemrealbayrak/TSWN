namespace yazilim_yapimi
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanicigiris = new System.Windows.Forms.Button();
            this.admingirisi = new System.Windows.Forms.Button();
            this.sinavsorumlusugiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanicigiris
            // 
            this.kullanicigiris.Location = new System.Drawing.Point(278, 12);
            this.kullanicigiris.Name = "kullanicigiris";
            this.kullanicigiris.Size = new System.Drawing.Size(171, 81);
            this.kullanicigiris.TabIndex = 0;
            this.kullanicigiris.Text = "kullanici giris";
            this.kullanicigiris.UseVisualStyleBackColor = true;
            this.kullanicigiris.Click += new System.EventHandler(this.kullanicigiris_Click);
            // 
            // admingirisi
            // 
            this.admingirisi.Location = new System.Drawing.Point(278, 145);
            this.admingirisi.Name = "admingirisi";
            this.admingirisi.Size = new System.Drawing.Size(171, 84);
            this.admingirisi.TabIndex = 1;
            this.admingirisi.Text = "admin giris";
            this.admingirisi.UseVisualStyleBackColor = true;
            this.admingirisi.Click += new System.EventHandler(this.admingirisi_Click);
            // 
            // sinavsorumlusugiris
            // 
            this.sinavsorumlusugiris.Location = new System.Drawing.Point(278, 294);
            this.sinavsorumlusugiris.Name = "sinavsorumlusugiris";
            this.sinavsorumlusugiris.Size = new System.Drawing.Size(171, 91);
            this.sinavsorumlusugiris.TabIndex = 2;
            this.sinavsorumlusugiris.Text = "sinav sorumlusu giris";
            this.sinavsorumlusugiris.UseVisualStyleBackColor = true;
            this.sinavsorumlusugiris.Click += new System.EventHandler(this.sinavsorumlusugiris_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sinavsorumlusugiris);
            this.Controls.Add(this.admingirisi);
            this.Controls.Add(this.kullanicigiris);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanicigiris;
        private System.Windows.Forms.Button admingirisi;
        private System.Windows.Forms.Button sinavsorumlusugiris;
    }
}