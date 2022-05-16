namespace OnlineSinavSistemi
{
    partial class FrmSorular
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.lblSoruID = new System.Windows.Forms.Label();
            this.rchSoruMetin = new System.Windows.Forms.RichTextBox();
            this.lblDogruSayisi = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSinaviBitir = new System.Windows.Forms.Button();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(60, 593);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(143, 29);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "radioButton1";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(60, 628);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(143, 29);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "radioButton2";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(60, 663);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(143, 29);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "radioButton3";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(60, 698);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(143, 29);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "radioButton4";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // lblSoruID
            // 
            this.lblSoruID.AutoSize = true;
            this.lblSoruID.Location = new System.Drawing.Point(12, 13);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(23, 25);
            this.lblSoruID.TabIndex = 5;
            this.lblSoruID.Text = "1";
            // 
            // rchSoruMetin
            // 
            this.rchSoruMetin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rchSoruMetin.Location = new System.Drawing.Point(60, 397);
            this.rchSoruMetin.Name = "rchSoruMetin";
            this.rchSoruMetin.Size = new System.Drawing.Size(615, 190);
            this.rchSoruMetin.TabIndex = 6;
            this.rchSoruMetin.Text = "";
            // 
            // lblDogruSayisi
            // 
            this.lblDogruSayisi.AutoSize = true;
            this.lblDogruSayisi.Location = new System.Drawing.Point(691, 39);
            this.lblDogruSayisi.Name = "lblDogruSayisi";
            this.lblDogruSayisi.Size = new System.Drawing.Size(23, 25);
            this.lblDogruSayisi.TabIndex = 9;
            this.lblDogruSayisi.Text = "0";
            this.lblDogruSayisi.Visible = false;
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(691, 14);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(23, 25);
            this.lblYanlis.TabIndex = 10;
            this.lblYanlis.Text = "0";
            this.lblYanlis.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSinaviBitir
            // 
            this.btnSinaviBitir.Location = new System.Drawing.Point(1135, 635);
            this.btnSinaviBitir.Name = "btnSinaviBitir";
            this.btnSinaviBitir.Size = new System.Drawing.Size(160, 36);
            this.btnSinaviBitir.TabIndex = 16;
            this.btnSinaviBitir.Text = "Sınavi Bitir";
            this.btnSinaviBitir.UseVisualStyleBackColor = true;
            this.btnSinaviBitir.Click += new System.EventHandler(this.btnSinaviBitir_Click);
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(1178, 9);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(55, 38);
            this.lblDakika.TabIndex = 17;
            this.lblDakika.Text = "00";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(1230, 9);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(55, 38);
            this.lblSaniye.TabIndex = 18;
            this.lblSaniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(1135, 677);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(160, 36);
            this.btnSonraki.TabIndex = 22;
            this.btnSonraki.Text = "Sonraki Soru";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // FrmSorular
            // 
            this.AcceptButton = this.btnSonraki;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 739);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.btnSinaviBitir);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogruSayisi);
            this.Controls.Add(this.rchSoruMetin);
            this.Controls.Add(this.lblSoruID);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSorular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSorular";
            this.Load += new System.EventHandler(this.FrmSorular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Label lblSoruID;
        private System.Windows.Forms.RichTextBox rchSoruMetin;
        private System.Windows.Forms.Label lblDogruSayisi;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSinaviBitir;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSonraki;
    }
}