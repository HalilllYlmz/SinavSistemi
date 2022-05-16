namespace OnlineSinavSistemi
{
    partial class FrmResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtYeniTekrar = new System.Windows.Forms.TextBox();
            this.btnSifreYenile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(122, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(74, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Şifre Tekrar :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(178, 22);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(180, 30);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(178, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 30);
            this.txtMail.TabIndex = 5;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(178, 171);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(180, 30);
            this.txtYeniSifre.TabIndex = 7;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtYeniTekrar
            // 
            this.txtYeniTekrar.Location = new System.Drawing.Point(178, 222);
            this.txtYeniTekrar.Name = "txtYeniTekrar";
            this.txtYeniTekrar.Size = new System.Drawing.Size(180, 30);
            this.txtYeniTekrar.TabIndex = 8;
            this.txtYeniTekrar.UseSystemPasswordChar = true;
            // 
            // btnSifreYenile
            // 
            this.btnSifreYenile.Location = new System.Drawing.Point(178, 283);
            this.btnSifreYenile.Name = "btnSifreYenile";
            this.btnSifreYenile.Size = new System.Drawing.Size(180, 32);
            this.btnSifreYenile.TabIndex = 8;
            this.btnSifreYenile.Text = "Şifreni Yenile";
            this.btnSifreYenile.UseVisualStyleBackColor = true;
            this.btnSifreYenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 258);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(178, 121);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(180, 30);
            this.txtEskiSifre.TabIndex = 6;
            this.txtEskiSifre.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(74, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Eski Şifre :";
            // 
            // FrmResetPassword
            // 
            this.AcceptButton = this.btnSifreYenile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(371, 337);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSifreYenile);
            this.Controls.Add(this.txtYeniTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Yenile";
            this.Load += new System.EventHandler(this.FrmResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtYeniTekrar;
        private System.Windows.Forms.Button btnSifreYenile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Label label5;
    }
}