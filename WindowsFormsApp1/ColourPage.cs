using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRSSSNamespace
{
    public partial class ColourPage : Form
    {
        public ColourPage()
        {
            InitializeComponent();

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


        }

        private void ColourPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            FinalPage openForm = new FinalPage();
            openForm.Show();
            Visible = false;

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox1.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox2.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox3.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox4.Image;
            
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox5.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox6.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox7.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputImage[3] = pictureBox8.Image;

            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }
    }
}
