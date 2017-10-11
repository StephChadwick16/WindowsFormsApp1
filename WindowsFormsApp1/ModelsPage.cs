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
    public partial class ModelsPage : Form
    {

        public static Image[] modelsImageArray;
        public static string[] modelsArray;


        private int start = 0, iteration = 0;
        string path;

        BackendLogic.FolderStructure currentFolderStructure = new BackendLogic.FolderStructure();

        public ModelsPage()
        {
            InitializeComponent();

            
            path = "\\Categories\\Category Models\\" + BackendLogic.arrayOfOutputInfo[0];
            currentFolderStructure = BackendLogic.CountFilesModelsFolders(path);

            ModelsRefresh();
        }

        public void ModelsRefresh()
        {

            //iteration += 3;

            pictureBox1.Image = null;
            ModelLabel1.Text = "";
            pictureBox1.Enabled = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = null;
            ModelLabel2.Text = "";
            pictureBox2.Enabled = false;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = null;
            ModelLabel3.Text = "";
            pictureBox3.Enabled = false;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            for (int i = 0; i < 3; i++)
            {

                if (i + start >= currentFolderStructure.arrayOfModelsImages.Length)
                {
                    break;
                }


                string fileName = currentFolderStructure.arrayOfModelsName[i + start];
                Image fileImage = currentFolderStructure.arrayOfModelsImages[i + start];

                if (i == 0)
                {
                    pictureBox1.Tag = "0,."+path+"\\"+fileName;
                    pictureBox1.Image = fileImage;
                    ModelLabel1.Text = fileName;
                    pictureBox1.Enabled = true;
                }


                if (i == 1)
                {
                    pictureBox2.Tag = "1,." + path + "\\" + fileName;
                    pictureBox2.Image = fileImage;
                    ModelLabel2.Text = fileName;
                    pictureBox2.Enabled = true;
                }


                if (i == 2)
                {
                    pictureBox3.Tag = "2,." + path + "\\" + fileName;
                    pictureBox3.Image = fileImage;
                    ModelLabel3.Text = fileName;
                    pictureBox3.Enabled = true;
                }

            }

            if (start + 3 >= currentFolderStructure.arrayOfModelsImages.Length)
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
            PreviousPgBtn.Visible = true;
            iteration += 3;
            
            ModelsRefresh();
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox me = sender as PictureBox;
            BackendLogic.FolderStructure StoreTempModel = BackendLogic.CountFilesModelsFolders(path);
            
            int x = iteration;
            Image[] z = BackendLogic.arrayOfOutputImage;
            BackendLogic.arrayOfOutputImage[1] = StoreTempModel.arrayOfModelsImages[int.Parse(me.Tag.ToString().Split(',')[0]) + iteration];
            
            BackendLogic.arrayOfOutputInfo[1] = StoreTempModel.arrayOfModelsName[int.Parse(me.Tag.ToString().Split(',')[0]) + iteration];

            if (Directory.Exists(me.Tag.ToString().Split(',')[1]))
            {
                SubPartsPage newSubpartsPage = new SubPartsPage();
                newSubpartsPage.Show();
                Visible = false;
            }

            else
            {
                ColourPage newColourPage = new ColourPage();
                newColourPage.Show();
                Visible = false;
            }
            
            
            
        }


         private void pictureBox2_Click(object sender, EventArgs e)
         {
            
            // Set so that if this picture box is clicked, it will perform the same action as picture box one (done through events handler in Properties)

            ColourPage newColourPage = new ColourPage();
            newColourPage.Show();
            Visible = false;

         }

        private void PreviousPgBtn_Click(object sender, EventArgs e)
        {
            start = (start - 3);
            int x = iteration;
            iteration -= 3;
            if (iteration == 0)
            {
                ((Button)sender).Visible = false;
            }
            if (iteration <= ((BackendLogic.arrayOfCategoriesImages.Length) / 3) + 1)
            {
                NextPageBtn.Visible = true;
            }

            ModelsRefresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            // Set so that if this picture box is clicked, it will perform the same action as picture box one (done through events handler in Properties)

            ColourPage newColourPage = new ColourPage();
            newColourPage.Show();
            Visible = false;
        }

        
        
    }
}
