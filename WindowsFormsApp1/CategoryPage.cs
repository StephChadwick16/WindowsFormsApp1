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
    public partial class CategoryPage : Form
    {
        private int start = 0, iteration = -3;

        public CategoryPage()
        {
            InitializeComponent();

            OptionSelected.Text = BackendLogic.inputOption.ToString();
            IntervalSelection.Text = BackendLogic.secondsTimer.ToString();
            StudentOption.Text = BackendLogic.studentName;


            CategoryRefresh();

        }


        public void CategoryRefresh()
        {

            iteration += 3;

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
                    Category1Label.Text = fileName;
                }


                if (i == 1)
                {
                    pictureBox2.Image = fileImage;
                    Category2Label.Text = fileName;
                }


                if (i == 2)
                {
                    pictureBox3.Image = fileImage;
                    Category3Label.Text = fileName;
                }

            }

            if (start + 3 >= BackendLogic.arrayOfCategoriesImages.Length)
            {
                NextPageBtn.Visible = false;
            }

            /*
            if (start - 3 >= BackendLogic.arrayOfCategoriesImages.Length)
            {
                PreviousPgBtn.Visible = false;
            }

            */

        }


        private void CategoryPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void OptionSelected_Click(object sender, EventArgs e)
        {

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

            CategoryRefresh();

        }

        private void PreviousPgBtn_Click(object sender, EventArgs e)
        {

            start = (start - 3);

            CategoryRefresh();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[0 + iteration];
            BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[0 + iteration];
            ModelsPage openForm = new ModelsPage();
            openForm.Show();
            Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[1 + iteration];
            BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[1 + iteration];
            ModelsPage openForm = new ModelsPage();
            openForm.Show();
            Visible = false;

        }
    
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[2 + iteration];
            BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[2 + iteration];
            ModelsPage openForm = new ModelsPage();
            openForm.Show();
            Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
