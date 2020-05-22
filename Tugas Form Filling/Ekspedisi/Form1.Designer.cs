namespace Ekspedisi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.bakun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btentangkami = new System.Windows.Forms.Button();
            this.bcustomerservice = new System.Windows.Forms.Button();
            this.blacakpaket = new System.Windows.Forms.Button();
            this.bcekharga = new System.Windows.Forms.Button();
            this.bkirimsekarang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bakun
            // 
            this.bakun.Image = ((System.Drawing.Image)(resources.GetObject("bakun.Image")));
            this.bakun.Location = new System.Drawing.Point(10, 12);
            this.bakun.Name = "bakun";
            this.bakun.Size = new System.Drawing.Size(117, 136);
            this.bakun.TabIndex = 7;
            this.bakun.UseVisualStyleBackColor = true;
            this.bakun.Click += new System.EventHandler(this.bakun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btentangkami
            // 
            this.btentangkami.BackColor = System.Drawing.SystemColors.Window;
            this.btentangkami.Image = ((System.Drawing.Image)(resources.GetObject("btentangkami.Image")));
            this.btentangkami.Location = new System.Drawing.Point(346, 290);
            this.btentangkami.Name = "btentangkami";
            this.btentangkami.Size = new System.Drawing.Size(118, 120);
            this.btentangkami.TabIndex = 5;
            this.btentangkami.Text = "Tentang Kami";
            this.btentangkami.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btentangkami.UseVisualStyleBackColor = false;
            this.btentangkami.Click += new System.EventHandler(this.btentangkami_Click);
            // 
            // bcustomerservice
            // 
            this.bcustomerservice.BackColor = System.Drawing.SystemColors.Window;
            this.bcustomerservice.Image = ((System.Drawing.Image)(resources.GetObject("bcustomerservice.Image")));
            this.bcustomerservice.Location = new System.Drawing.Point(10, 290);
            this.bcustomerservice.Name = "bcustomerservice";
            this.bcustomerservice.Size = new System.Drawing.Size(118, 120);
            this.bcustomerservice.TabIndex = 4;
            this.bcustomerservice.Text = "Customer Service";
            this.bcustomerservice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bcustomerservice.UseVisualStyleBackColor = false;
            this.bcustomerservice.Click += new System.EventHandler(this.bcustomerservice_Click);
            // 
            // blacakpaket
            // 
            this.blacakpaket.BackColor = System.Drawing.SystemColors.Window;
            this.blacakpaket.Image = ((System.Drawing.Image)(resources.GetObject("blacakpaket.Image")));
            this.blacakpaket.Location = new System.Drawing.Point(231, 290);
            this.blacakpaket.Name = "blacakpaket";
            this.blacakpaket.Size = new System.Drawing.Size(118, 120);
            this.blacakpaket.TabIndex = 3;
            this.blacakpaket.Text = "Lacak Paket";
            this.blacakpaket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.blacakpaket.UseVisualStyleBackColor = false;
            this.blacakpaket.Click += new System.EventHandler(this.blacakpaket_Click);
            // 
            // bcekharga
            // 
            this.bcekharga.BackColor = System.Drawing.SystemColors.Window;
            this.bcekharga.Image = ((System.Drawing.Image)(resources.GetObject("bcekharga.Image")));
            this.bcekharga.Location = new System.Drawing.Point(122, 290);
            this.bcekharga.Name = "bcekharga";
            this.bcekharga.Size = new System.Drawing.Size(112, 120);
            this.bcekharga.TabIndex = 1;
            this.bcekharga.Text = "Cek Harga Pengiriman";
            this.bcekharga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bcekharga.UseVisualStyleBackColor = false;
            this.bcekharga.Click += new System.EventHandler(this.button2_Click);
            // 
            // bkirimsekarang
            // 
            this.bkirimsekarang.BackColor = System.Drawing.SystemColors.Window;
            this.bkirimsekarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkirimsekarang.Image = ((System.Drawing.Image)(resources.GetObject("bkirimsekarang.Image")));
            this.bkirimsekarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bkirimsekarang.Location = new System.Drawing.Point(10, 145);
            this.bkirimsekarang.Name = "bkirimsekarang";
            this.bkirimsekarang.Size = new System.Drawing.Size(454, 148);
            this.bkirimsekarang.TabIndex = 0;
            this.bkirimsekarang.Text = "Kirim Sekarang";
            this.bkirimsekarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bkirimsekarang.UseVisualStyleBackColor = false;
            this.bkirimsekarang.Click += new System.EventHandler(this.bkirimsekarang_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(180, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 64;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 468);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bakun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btentangkami);
            this.Controls.Add(this.bcustomerservice);
            this.Controls.Add(this.blacakpaket);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bcekharga);
            this.Controls.Add(this.bkirimsekarang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HURU HARA EKSPEDISI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bkirimsekarang;
        private System.Windows.Forms.Button bcekharga;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button blacakpaket;
        private System.Windows.Forms.Button bcustomerservice;
        private System.Windows.Forms.Button btentangkami;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bakun;
        private System.Windows.Forms.Button button2;
    }
}

