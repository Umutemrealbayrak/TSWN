namespace yazilim_yapimi
{
    partial class Form8
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
            this.kaydet = new System.Windows.Forms.Button();
            this.btn_soru = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ofdResim = new System.Windows.Forms.OpenFileDialog();
            this.table_5TableAdapter1 = new yazilim_yapimi.soruDataSet5TableAdapters.Table_5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(967, 86);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 0;
            this.kaydet.Text = "EKLE";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click_1);
            // 
            // btn_soru
            // 
            this.btn_soru.Location = new System.Drawing.Point(1137, 86);
            this.btn_soru.Name = "btn_soru";
            this.btn_soru.Size = new System.Drawing.Size(75, 23);
            this.btn_soru.TabIndex = 1;
            this.btn_soru.Text = "GETIR";
            this.btn_soru.UseVisualStyleBackColor = true;
            this.btn_soru.Click += new System.EventHandler(this.btn_soru_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 743);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(987, 380);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 138);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // ofdResim
            // 
            this.ofdResim.FileName = "openFileDialog1";
            // 
            // table_5TableAdapter1
            // 
            this.table_5TableAdapter1.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1313, 767);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_soru);
            this.Controls.Add(this.kaydet);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button btn_soru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog ofdResim;
        private soruDataSet5TableAdapters.Table_5TableAdapter table_5TableAdapter1;
    }
}