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
        TimeSpan tsCategoriesSelection;
        TimeSpan tsModelsSelection;
        TimeSpan tsColoursSelection;
        TimeSpan tsSizesSelection;
        TimeSpan tsOverallTime;

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


            // Showing category chosen
            ShowsCategoryChosen.Text = BackendLogic.arrayOfOutputInfo[0];
            pictureBox1.Image = BackendLogic.arrayOfOutputImage[0];

            // Showing model chosen
            ShowsModelChosen.Text = BackendLogic.arrayOfOutputInfo[1];
            pictureBox2.Image = BackendLogic.arrayOfOutputImage[1];

            // Showing size chosen
            ShowsSizeChosen.Text = BackendLogic.arrayOfOutputInfo[2];
            pictureBox3.Image = BackendLogic.arrayOfOutputImage[2];

            // Showing colour chosen
            pictureBox4.Image = BackendLogic.arrayOfOutputImage[3];


            // Sub parts shown on final page
            int numSubParts = BackendLogic.arrayOfSPImage.Count;

            if (numSubParts > 0)
            {
                SP1PicBox.Image = BackendLogic.arrayOfSPImage[0];
                SubPart1Label.Text = BackendLogic.arrayOfSPInfo[0].Split('.')[0];
                Colour1PicBox.Image = BackendLogic.arrayOfSPColour[0];

                ColourPanel.Visible = false;

                if (numSubParts > 1)
                {
                    SP2PicBox.Image = BackendLogic.arrayOfSPImage[1];
                    SubPart2Label.Text = BackendLogic.arrayOfSPInfo[1].Split('.')[0];
                    Colour2PicBox.Image = BackendLogic.arrayOfSPColour[1];

                    if (numSubParts > 2)
                    {
                        SP3PicBox.Image = BackendLogic.arrayOfSPImage[2];
                        SubPart3Label.Text = BackendLogic.arrayOfSPInfo[2].Split('.')[0];
                        Colour3PicBox.Image = BackendLogic.arrayOfSPColour[2];
                    }
                    else
                    {
                        SP3PicBox.Visible = false;
                        SubPart3Label.Visible = false;
                        Colour3PicBox.Visible = false;
                        Colour3Label.Visible = false;
                    }
                }
            }
            else
            {
                SubPartsPanel.Visible = false;

                // set up the other colour panel 
                // this is for when there isn't any subparts!
            }

            SP1PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Colour1PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SP2PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Colour2PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SP3PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Colour3PicBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Calculate Times
            tsCategoriesSelection = BackendLogic.todCategoriesDone - BackendLogic.todInputDone;
            tsModelsSelection = BackendLogic.todModelsDone - BackendLogic.todCategoriesDone;
            tsColoursSelection = BackendLogic.todColoursDone - BackendLogic.todModelsDone;
            tsSizesSelection = BackendLogic.todSizesDone - BackendLogic.todColoursDone;
            tsOverallTime = BackendLogic.todSizesDone - BackendLogic.todInputDone;

            ShowsProgramTime.Text = tsOverallTime.ToString(@"hh\:mm\:ss");
            ShowsCategoryTime.Text = tsCategoriesSelection.ToString(@"hh\:mm\:ss");
            ShowsModelTime.Text = tsModelsSelection.ToString(@"hh\:mm\:ss");
            ShowsColourTime.Text = tsColoursSelection.ToString(@"hh\:mm\:ss");
            ShowsSizeTime.Text = tsSizesSelection.ToString(@"hh\:mm\:ss");
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
