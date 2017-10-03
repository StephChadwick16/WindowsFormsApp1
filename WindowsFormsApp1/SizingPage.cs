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
    public partial class SizingPage : Form
    {
        public SizingPage()
        {
            InitializeComponent();

            pictureBox1.Image = BackendLogic.arrayOfSizes[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = BackendLogic.arrayOfSizes[1];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = BackendLogic.arrayOfSizes[2];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void SizingPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            ColourPage newColourPage = new ColourPage();
            newColourPage.Show();
            Visible = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FinalPage newColourPage = new FinalPage();
            newColourPage.Show();
            Visible = false;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FinalPage newColourPage = new FinalPage();
            newColourPage.Show();
            Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FinalPage newColourPage = new FinalPage();
            newColourPage.Show();
            Visible = false;
        }

        private void SmallLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
