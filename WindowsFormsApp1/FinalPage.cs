using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRSSSNamespace
{
    public partial class FinalPage : Form
    {
        public FinalPage()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            OptionSelected.Text = BackendLogic.inputOption.ToString();
            IntervalSelection.Text = BackendLogic.secondsTimer.ToString();
            StudentOption.Text = BackendLogic.studentName;

            ShowsCategoryChosen.Text = BackendLogic.arrayOfOutputInfo[0];
            pictureBox1.Image = BackendLogic.arrayOfOutputImage[0];

            ShowsModelChosen.Text = BackendLogic.arrayOfOutputInfo[1];
            pictureBox2.Image = BackendLogic.arrayOfOutputImage[1];

            ShowsSizeChosen.Text = BackendLogic.arrayOfOutputInfo[2];
            pictureBox3.Image = BackendLogic.arrayOfOutputImage[2];

            // Showing colour chosen
            pictureBox4.Image = BackendLogic.arrayOfOutputImage[3];


            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;




        }

        private void FinalPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void SettingsAndTimesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BitmapSave(string FileName)
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(FileName, ImageFormat.Jpeg);

                bmp.Dispose();
            }
                        
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFinalPage = new SaveFileDialog();
            SaveFinalPage.Filter = "JPEG Files|*jpg.";
            SaveFinalPage.DefaultExt = "jpg";

            if (SaveFinalPage.ShowDialog(this) == DialogResult.OK)
            {
               BitmapSave(SaveFinalPage.FileName);

            }
            
        }
    }

}
