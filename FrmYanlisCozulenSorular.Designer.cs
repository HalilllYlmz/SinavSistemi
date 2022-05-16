namespace OnlineSinavSistemi
{
    partial class FrmYanlisCozulenSorular
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYanlisCozulenSorular));
            this.btnSonraki = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblKullaniciIsim = new System.Windows.Forms.Label();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.rchSoruMetin = new System.Windows.Forms.RichTextBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.btnSinaviBitir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCevap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSonraki
            // 
            this.btnSonraki.ImageKey = "sonraki.png";
            this.btnSonraki.ImageList = this.ımageList1;
            this.btnSonraki.Location = new System.Drawing.Point(941, 667);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(44, 44);
            this.btnSonraki.TabIndex = 38;
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sonraki.png");
            this.ımageList1.Images.SetKeyName(1, "sonraki.png");
            // 
            // lblKullaniciIsim
            // 
            this.lblKullaniciIsim.AutoSize = true;
            this.lblKullaniciIsim.Location = new System.Drawing.Point(828, 8);
            this.lblKullaniciIsim.Name = "lblKullaniciIsim";
            this.lblKullaniciIsim.Size = new System.Drawing.Size(105, 25);
            this.lblKullaniciIsim.TabIndex = 37;
            this.lblKullaniciIsim.Text = "UserName";
            this.lblKullaniciIsim.Visible = false;
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(828, 33);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(122, 25);
            this.lblKontrol.TabIndex = 35;
            this.lblKontrol.Text = "Dogu Cevap";
            this.lblKontrol.Visible = false;
            // 
            // rchSoruMetin
            // 
            this.rchSoruMetin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rchSoruMetin.Location = new System.Drawing.Point(43, 392);
            this.rchSoruMetin.Name = "rchSoruMetin";
            this.rchSoruMetin.Size = new System.Drawing.Size(648, 190);
            this.rchSoruMetin.TabIndex = 29;
            this.rchSoruMetin.Text = "";
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(2, 691);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(143, 29);
            this.radioButtonD.TabIndex = 27;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "radioButton4";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(2, 658);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(143, 29);
            this.radioButtonC.TabIndex = 26;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "radioButton3";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(2, 623);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(143, 29);
            this.radioButtonB.TabIndex = 25;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "radioButton2";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(2, 588);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(143, 29);
            this.radioButtonA.TabIndex = 24;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "radioButton1";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(828, 58);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(23, 25);
            this.lblSoruNo.TabIndex = 39;
            this.lblSoruNo.Text = "0";
            this.lblSoruNo.Visible = false;
            // 
            // btnSinaviBitir
            // 
            this.btnSinaviBitir.Location = new System.Drawing.Point(825, 61);
            this.btnSinaviBitir.Name = "btnSinaviBitir";
            this.btnSinaviBitir.Size = new System.Drawing.Size(160, 36);
            this.btnSinaviBitir.TabIndex = 40;
            this.btnSinaviBitir.Text = "Sınavi Bitir";
            this.btnSinaviBitir.UseVisualStyleBackColor = true;
            this.btnSinaviBitir.Click += new System.EventHandler(this.btnSinaviBitir_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCevap
            // 
            this.btnCevap.Location = new System.Drawing.Point(825, 12);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(160, 36);
            this.btnCevap.TabIndex = 42;
            this.btnCevap.Text = "Cevap";
            this.btnCevap.UseVisualStyleBackColor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevap_Click);
            // 
            // FrmYanlisCozulenSorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 723);
            this.Controls.Add(this.btnCevap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSinaviBitir);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblKullaniciIsim);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.rchSoruMetin);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmYanlisCozulenSorular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmYanlisCozulenSorular";
            this.Load += new System.EventHandler(this.FrmYanlisCozulenSorular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Label lblKullaniciIsim;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.RichTextBox rchSoruMetin;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Button btnSinaviBitir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCevap;
        private System.Windows.Forms.ImageList ımageList1;
    }
}