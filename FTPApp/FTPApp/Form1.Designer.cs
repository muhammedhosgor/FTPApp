namespace FTPApp
{
    partial class FtpAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtpAppForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.TextBox();
            this.picFileSelect = new System.Windows.Forms.PictureBox();
            this.selectList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectFileLenght = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectFileCount = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.selectFileCountText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSelect)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ftp App V1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1176, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 102);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 10);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serverPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.serverName);
            this.groupBox1.Controls.Add(this.picFileSelect);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sunucu Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sunucu Parola:";
            // 
            // serverPassword
            // 
            this.serverPassword.Location = new System.Drawing.Point(17, 111);
            this.serverPassword.Name = "serverPassword";
            this.serverPassword.Size = new System.Drawing.Size(355, 22);
            this.serverPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sunucu Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(408, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dosya Seç";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(17, 53);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(356, 22);
            this.serverName.TabIndex = 0;
            // 
            // picFileSelect
            // 
            this.picFileSelect.Image = ((System.Drawing.Image)(resources.GetObject("picFileSelect.Image")));
            this.picFileSelect.Location = new System.Drawing.Point(407, 29);
            this.picFileSelect.Name = "picFileSelect";
            this.picFileSelect.Size = new System.Drawing.Size(91, 82);
            this.picFileSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFileSelect.TabIndex = 5;
            this.picFileSelect.TabStop = false;
            this.picFileSelect.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // selectList
            // 
            this.selectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(78)))), ((int)(((byte)(110)))));
            this.selectList.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectList.ForeColor = System.Drawing.Color.White;
            this.selectList.FormattingEnabled = true;
            this.selectList.ItemHeight = 17;
            this.selectList.Location = new System.Drawing.Point(551, 143);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(679, 310);
            this.selectList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectFileLenght);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.selectFileCount);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.selectFileCountText);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sunucu Bilgileri";
            // 
            // selectFileLenght
            // 
            this.selectFileLenght.AutoSize = true;
            this.selectFileLenght.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLenght.ForeColor = System.Drawing.Color.White;
            this.selectFileLenght.Location = new System.Drawing.Point(174, 78);
            this.selectFileLenght.Name = "selectFileLenght";
            this.selectFileLenght.Size = new System.Drawing.Size(15, 17);
            this.selectFileLenght.TabIndex = 10;
            this.selectFileLenght.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seçilen Dosya Boyutu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(411, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gönder";
            // 
            // selectFileCount
            // 
            this.selectFileCount.AutoSize = true;
            this.selectFileCount.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileCount.ForeColor = System.Drawing.Color.White;
            this.selectFileCount.Location = new System.Drawing.Point(175, 33);
            this.selectFileCount.Name = "selectFileCount";
            this.selectFileCount.Size = new System.Drawing.Size(15, 17);
            this.selectFileCount.TabIndex = 3;
            this.selectFileCount.Text = "0";
            // 
            // btnSend
            // 
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(406, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 82);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSend.TabIndex = 7;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // selectFileCountText
            // 
            this.selectFileCountText.AutoSize = true;
            this.selectFileCountText.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileCountText.ForeColor = System.Drawing.Color.White;
            this.selectFileCountText.Location = new System.Drawing.Point(14, 32);
            this.selectFileCountText.Name = "selectFileCountText";
            this.selectFileCountText.Size = new System.Drawing.Size(136, 17);
            this.selectFileCountText.TabIndex = 2;
            this.selectFileCountText.Text = "Seçilen Dosya Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1150, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Temizle";
            // 
            // picClear
            // 
            this.picClear.Image = ((System.Drawing.Image)(resources.GetObject("picClear.Image")));
            this.picClear.Location = new System.Drawing.Point(1146, 458);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(76, 64);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClear.TabIndex = 7;
            this.picClear.TabStop = false;
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(118, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Desing By Muhammed Hoşgör";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 458);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // FtpAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(56)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1247, 558);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picClear);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FtpAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FtpApp";
            this.Load += new System.EventHandler(this.FtpAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileSelect)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.PictureBox picFileSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label selectFileCount;
        private System.Windows.Forms.Label selectFileCountText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.Label selectFileLenght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

