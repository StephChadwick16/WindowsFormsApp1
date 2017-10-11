using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRSSSNamespace
{
    public partial class SubPartsPage : Form
    {

        string path;

        private int currentSubPart = 0;


        public SubPartsPage()
        {
            InitializeComponent();

            path = ".\\Categories\\Category Models\\" + BackendLogic.arrayOfOutputInfo[0] + "\\" + BackendLogic.arrayOfOutputInfo[1];
            //path = string.Format(".\\Categories\\Category Models\\{0}\\{1}", BackendLogic.arrayOfOutputInfo[0], BackendLogic.arrayOfOutputInfo[1]);
                        
            foreach (var file in Directory.EnumerateFiles(path, "*"))
            {
                FileInfo fi = new FileInfo(file);
                Image img = Image.FromFile(file);
                BackendLogic.arrayOfSPImage.Add(img);
                BackendLogic.arrayOfSPInfo.Add(fi.Name);
            }


            pictureBox1.Image = BackendLogic.arrayOfColours[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = BackendLogic.arrayOfColours[1];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = BackendLogic.arrayOfColours[2];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = BackendLogic.arrayOfColours[3];
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = BackendLogic.arrayOfColours[4];
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = BackendLogic.arrayOfColours[5];
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.Image = BackendLogic.arrayOfColours[6];
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox8.Image = BackendLogic.arrayOfColours[7];
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;


            SubPartsRefresh();

        }

        public void SubPartsRefresh()
        {
            SubPartPicBox.Image = BackendLogic.arrayOfSPImage[currentSubPart];
            SubPartNameLabel.Text = BackendLogic.arrayOfSPInfo[currentSubPart].Split('.')[0];
            SubPartPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SelectColour(int index)
        {
            BackendLogic.arrayOfSPColour.Add(BackendLogic.arrayOfColours[index]);
            currentSubPart++;
            if (currentSubPart == BackendLogic.arrayOfSPImage.Count)
            {
                SizingPage openForm = new SizingPage();
                openForm.Show();
                Visible = false;
            }
            else
            {
                SubPartsRefresh();
            }
        }


        private void SubPartsPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SelectColour(0);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SelectColour(1);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SelectColour(2);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SelectColour(3);
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            SelectColour(4);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            SelectColour(5);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            SelectColour(6);
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            SelectColour(7);
        }

       
    }
}
