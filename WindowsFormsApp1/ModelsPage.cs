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
    public partial class ModelsPage : Form
    {

        private int start = 0;

        private string SelectedModel = "error";


        public ModelsPage()
        {
            InitializeComponent();


            ModelsRefresh();


        }

        public void ModelsRefresh()
        {

            pictureBox1.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = null;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = null;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            for (int i = 0; i < 3; i++)
            {

                if (i + start >= BackendLogic.arrayOfCategoriesImages.Length)
                {
                    break;
                }


                string fileName = BackendLogic.arrayOfCategoriesName[i + start];
                Image fileImage = BackendLogic.arrayOfCategoriesImages[i + start];

                if (i == 0)
                {
                    pictureBox1.Image = fileImage;
                    ModelLabel1.Text = fileName;
                    SelectedModel = fileName;
                }


                if (i == 1)
                {
                    pictureBox2.Image = fileImage;
                    ModelLabel2.Text = fileName;
                    SelectedModel = fileName;
                }


                if (i == 2)
                {
                    pictureBox3.Image = fileImage;
                    ModelLabel3.Text = fileName;
                    SelectedModel = fileName;
                }

            }

            if (start + 3 >= BackendLogic.arrayOfCategoriesImages.Length)
            {
                NextPageBtn.Visible = false;
            }

        }


        private void ModelsPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {

            start = (start + 3);

            ModelsRefresh();
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;
        }


         private void pictureBox2_Click(object sender, EventArgs e)
         {
            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;

         }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;
        }

        public void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = BackendLogic.ModelsDir(ToString);
        }
    }
}
