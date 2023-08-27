using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace FTPApp
{
    public partial class FtpAppForm : Form
    {
        public FtpAppForm()
        {
            InitializeComponent();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;
        string[] arrAllFiles;

        private void FtpAppForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();

            choofdlog.Filter = "All Files (*.*)|*.*";

            choofdlog.FilterIndex = 1;

            choofdlog.Multiselect = true;



            if (choofdlog.ShowDialog() == DialogResult.OK)

            {

                string sFileName = choofdlog.FileName;

                arrAllFiles = choofdlog.FileNames; //used when Multiselect = true

                for (int i = 0; i < arrAllFiles.Length; i++)
                {
                    selectList.Items.Add(arrAllFiles[i]);               }

                selectFileCount.Text=arrAllFiles.Count().ToString();
               selectFileLenght.Text=arrAllFiles.Length.ToString();


            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (serverName.Text == "" && serverPassword.Text == "")
            {
                String title = "Hata";
                String message = "Lütfen Sunucu Adı ve Şifre alanını kontrol ediniz";
                MessageBox.Show(message, title);
            }
            else
            {
                try
                {
                    foreach (string fileName in arrAllFiles) // Dizideki her dosya için işlem yap
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        String ftpAdress = "ftp://" + serverName.Text + "/" + fileInfo.Name;
                        FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri(ftpAdress));
                        ftpWebRequest.Credentials = new NetworkCredential(serverName.Text, serverPassword.Text);
                        ftpWebRequest.KeepAlive = false;
                        ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
                        ftpWebRequest.UseBinary = true;
                        ftpWebRequest.ContentLength = fileInfo.Length;

                        int bufferLenght = 2048;
                        byte[] buff = new byte[bufferLenght]; // Düzeltme: Buff boyutunu düzelt
                        int number;
                        FileStream stream = fileInfo.OpenRead();
                        Stream str = ftpWebRequest.GetRequestStream();
                        number = stream.Read(buff, 0, bufferLenght);
                        while (number != 0)
                        {
                            str.Write(buff, 0, number);
                            number = stream.Read(buff, 0, bufferLenght);
                        }
                        str.Close();
                        stream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void picClear_Click(object sender, EventArgs e)
        {
            
          
            if (selectList.Items !=null)
            {
                selectList.Items.Clear();
                String title = "Başarılı";
                String message = "Temizleme işlemi başarılı.";
                MessageBox.Show(message, title);
                selectFileCount.Text = "0";
                selectFileLenght.Text = "0";
            }
            else
            {
                String title = "Uyarı";
                String message = "Liste de silinecek öğe bulunamadı.";
                MessageBox.Show(message, title);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

