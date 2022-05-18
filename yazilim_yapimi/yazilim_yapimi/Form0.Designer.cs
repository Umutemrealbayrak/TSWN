
namespace yazilim_yapimi
{
    partial class Form0
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
            this.kayit = new System.Windows.Forms.Button();
            this.v = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kayit
            // 
            this.kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit.Location = new System.Drawing.Point(408, 283);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(100, 28);
            this.kayit.TabIndex = 0;
            this.kayit.Text = "KAYIT OL";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.v.Location = new System.Drawing.Point(122, 131);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(111, 16);
            this.v.TabIndex = 1;
            this.v.Text = "KULLANICI ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIFRE";
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Location = new System.Drawing.Point(408, 131);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(100, 22);
            this.kullaniciadi.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(408, 202);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 22);
            this.sifre.TabIndex = 4;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.kayit);
            this.Name = "Form0";
            this.Text = "Form0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.TextBox sifre;
    }
}