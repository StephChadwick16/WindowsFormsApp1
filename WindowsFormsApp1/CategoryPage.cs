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
    public partial class CategoryPage : Form
    {
        private int start = 0;
        string path;

        //BackendLogic.FolderStructure currentFolderStructure = new BackendLogic.FolderStructure();

        public CategoryPage()
        {
                       
            InitializeComponent();

            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Interval = BackendLogic.secondsTimer * 1000;
                timerSwitch.Enabled = true;
            }

            path = "\\Categories\\" + BackendLogic.arrayOfOutputInfo[0];
            //currentFolderStructure = BackendLogic.CountFilesCategoriesFolder(path);

            CategoryRefresh();

        }


        public void CategoryRefresh()
        {

            int iCategoryIndex = 0;
            int iCategoryCount = BackendLogic.arrayOfCategoriesImages.Length;
            if (start >= iCategoryCount) start = iCategoryCount - 1;
            if (start < 0) start = 0;

            Category1Label.Text = "";
            butSelectionA.Enabled = false;
            butSelectionA.Visible = false;
            butSelectionA.FlatAppearance.BorderColor = Color.Black;
            

            Category2Label.Text = "";
            butSelectionB.Enabled = false;
            butSelectionB.Visible = false;
            butSelectionB.FlatAppearance.BorderColor = Color.Black;

            Category3Label.Text = "";
            butSelectionC.Enabled = false;
            butSelectionC.Visible = false;
            butSelectionC.FlatAppearance.BorderColor = Color.Black;


            for (int i = 0; i < 3; i++)
            {

                iCategoryIndex = i + start;

                if (iCategoryIndex < iCategoryCount)
                { 
                    string fileName = BackendLogic.arrayOfCategoriesName[iCategoryIndex];
                    Image fileImage = BackendLogic.arrayOfCategoriesImages[iCategoryIndex];

                    if (i == 0)
                    {
                        Category1Label.Text = fileName;
                        butSelectionA.Enabled = true;
                        butSelectionA.Visible = true;
                        butSelectionA.Tag = "0,." + path + "\\" + fileName;
                        butSelectionA.BackgroundImage = fileImage;
                    }


                    if (i == 1)
                    {
                        Category2Label.Text = fileName;
                        butSelectionB.Enabled = true;
                        butSelectionB.Visible = true;
                        butSelectionB.Tag = "1,." + path + "\\" + fileName;
                        butSelectionB.BackgroundImage = fileImage;
                    }

                    if (i == 2)
                    {
                        Category3Label.Text = fileName;
                        butSelectionC.Enabled = true;
                        butSelectionC.Visible = true;
                        butSelectionC.Tag = "2,." + path + "\\" + fileName;
                        butSelectionC.BackgroundImage = fileImage;
                    }

                }
                else
                {
                    if (i == 0)
                    {
                        butSelectionA.Enabled = false;
                        butSelectionA.Visible = false;
                    }
                    if (i == 1)
                    {
                        butSelectionB.Enabled = false;
                        butSelectionB.Visible = false;
                    }
                    if (i == 2)
                    {
                        butSelectionC.Enabled = false;
                        butSelectionC.Visible = false;
                    }
                }
            }

            if (start + 3 >= iCategoryCount)
            {
                NextPageBtn.Visible = false;
            }
            else
            {
                NextPageBtn.Visible = true;
            }

            if (start == 0)
            {
                PreviousPgBtn.Visible = false;
            }
            else
            {
                PreviousPgBtn.Visible = true;
            }

            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Start();
            }
       
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Category_Click1(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todCategoriesDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[start];
            BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[start];

            ModelsPage newModelsPage = new ModelsPage();
            newModelsPage.Show();
            Visible = false;
            

        }

        private void Category_Click2(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todCategoriesDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[start + 1];
            BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[start + 1];

            ModelsPage newModelsPage = new ModelsPage();
            newModelsPage.Show();
            Visible = false;


        }
        private void Category_Click3(object sender, EventArgs e)
        {
            Button me = sender as Button;
            
            
                BackendLogic.todCategoriesDone = DateTime.Now;
                BackendLogic.arrayOfOutputImage[0] = BackendLogic.arrayOfCategoriesImages[start + 2];
                BackendLogic.arrayOfOutputInfo[0] = BackendLogic.arrayOfCategoriesName[start + 2];

                ModelsPage newModelsPage = new ModelsPage();
                newModelsPage.Show();
                Visible = false;

            
        }

        private void butSelection_Enter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Color.Red;
        }
        private void butSelection_Leave(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Color.Black;
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            Control ctlCurr;

            if (BackendLogic.inputOption == 1)
            {
                ctlCurr = ActiveControl.Parent;
                ctlCurr.SelectNextControl(ActiveControl, true, true, true, true);
                timerSwitch.Start();
            }
        }


        private void butSelection_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctlCurr;

            if (BackendLogic.inputOption == 2)
            {
                if (e.KeyCode == Keys.Tab)
                {
                    ctlCurr = ((Button)sender).Parent;
                    ctlCurr.SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
        }



        private void butSelection_KeyUp(object sender, KeyEventArgs e)
        {
            Control ctlCurr;


            if (BackendLogic.inputOption == 2)
            {
                if (e.KeyCode == Keys.Space)
                {
                    ctlCurr = ((Button)sender).Parent;
                    ctlCurr.SelectNextControl(ActiveControl, true, true, true, true);
                }
            }

        }

        private void CategoryPage_Load_1(object sender, EventArgs e)
        {

        }

        private void Category1Label_Click(object sender, EventArgs e)
        {

        }
    }
}