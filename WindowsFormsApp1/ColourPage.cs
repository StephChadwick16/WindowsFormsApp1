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

            pictureBox1.Image = BackendLogic.ImageArray[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = BackendLogic.ImageArray[1];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = BackendLogic.ImageArray[2];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.Image = BackendLogic.ImageArray[3];
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = BackendLogic.ImageArray[4];
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox6.Image = BackendLogic.ImageArray[5];
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            //pictureBox7.Image = BackendLogic.ImageArray[6];
            //pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void ColourPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            FinalPage openForm = new FinalPage();
            openForm.Show();
            Visible = false;

        }
    }
}
