namespace OnlineSinavSistemi
{
    partial class FrmOgrSnvSonuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrSnvSonuc));
            this.dataGridViewSonuclar = new System.Windows.Forms.DataGridView();
            this.cmbOgrenciIsım = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSonuclar
            // 
            this.dataGridViewSonuclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonuclar.Location = new System.Drawing.Point(13, 144);
            this.dataGridViewSonuclar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSonuclar.Name = "dataGridViewSonuclar";
            this.dataGridViewSonuclar.RowHeadersWidth = 51;
            this.dataGridViewSonuclar.RowTemplate.Height = 24;
            this.dataGridViewSonuclar.Size = new System.Drawing.Size(880, 580);
            this.dataGridViewSonuclar.TabIndex = 0;
            // 
            // cmbOgrenciIsım
            // 
            this.cmbOgrenciIsım.FormattingEnabled = true;
            this.cmbOgrenciIsım.Location = new System.Drawing.Point(4, 94);
            this.cmbOgrenciIsım.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOgrenciIsım.Name = "cmbOgrenciIsım";
            this.cmbOgrenciIsım.Size = new System.Drawing.Size(180, 33);
            this.cmbOgrenciIsım.TabIndex = 1;
            this.cmbOgrenciIsım.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciIsım_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lütfen öğrenci seçiniz.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmOgrSnvSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 738);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOgrenciIsım);
            this.Controls.Add(this.dataGridViewSonuclar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgrSnvSonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrSnvSonuc";
            this.Load += new System.EventHandler(this.FrmOgrSnvSonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonuclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSonuclar;
        private System.Windows.Forms.ComboBox cmbOgrenciIsım;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}