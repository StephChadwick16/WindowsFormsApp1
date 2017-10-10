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
    public partial class SubPartsPage : Form
    {

        private int start = 0, iteration = -3;
        string path;


        public SubPartsPage()
        {
            InitializeComponent();

            path = "\\Categories\\Category Models\\" + BackendLogic.arrayOfOutputInfo[0] + BackendLogic.arrayOfOutputInfo[1];
            //currentFolderStructure = BackendLogic.CountFilesModelsFolders(path);


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

            iteration += 3;

            SubPartPicBox.Image = null;
            SubPartPicBox.SizeMode = PictureBoxSizeMode.StretchImage;



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
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            SizingPage openForm = new SizingPage();
            openForm.Show();
            Visible = false;
        }

       
    }
}
