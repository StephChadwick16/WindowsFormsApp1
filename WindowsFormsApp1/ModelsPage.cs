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
        private int start = 0;
        string path;

        BackendLogic.FolderStructure currentFolderStructure = new BackendLogic.FolderStructure();

        public ModelsPage()
        {
            InitializeComponent();

            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Interval = BackendLogic.secondsTimer * 1000;
                timerSwitch.Enabled = true;
            }

            path = "\\Categories\\Category Models\\" + BackendLogic.arrayOfOutputInfo[0];
            currentFolderStructure = BackendLogic.CountFilesModelsFolders(path);

            ModelsRefresh();
        }

        public void ModelsRefresh()
        {
            int iModelIndex = 0;
            int iModelCount = currentFolderStructure.arrayOfModelsImages.Length;
            if (start >= iModelCount) start = iModelCount - 1;
            if (start < 0) start = 0;

            ModelLabel1.Text = "";
            butSelectionA.Enabled = false;
            butSelectionA.Visible = false;
            butSelectionA.FlatAppearance.BorderColor = Color.Black;

            ModelLabel2.Text = "";
            butSelectionB.Enabled = false;
            butSelectionB.Visible = false;
            butSelectionB.FlatAppearance.BorderColor = Color.Black;

            ModelLabel3.Text = "";
            butSelectionC.Enabled = false;
            butSelectionC.Visible = false;
            butSelectionC.FlatAppearance.BorderColor = Color.Black;

            for (int i = 0; i < 3; i++)
            {
                iModelIndex = i + start;

                if (iModelIndex < iModelCount)
                {
                    string fileName = currentFolderStructure.arrayOfModelsName[iModelIndex];
                    Image fileImage = currentFolderStructure.arrayOfModelsImages[iModelIndex];

                    if (i == 0)
                    {
                        ModelLabel1.Text = fileName;
                        butSelectionA.Enabled = true;
                        butSelectionA.Visible = true;
                        butSelectionA.Tag = "0,." + path + "\\" + fileName;
                        butSelectionA.BackgroundImage = fileImage;
                    }

                    if (i == 1)
                    {
                        ModelLabel2.Text = fileName;
                        butSelectionB.Enabled = true;
                        butSelectionB.Visible = true;
                        butSelectionB.Tag = "1,." + path + "\\" + fileName;
                        butSelectionB.BackgroundImage = fileImage;
                    }

                    if (i == 2)
                    {
                        ModelLabel3.Text = fileName;
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

            if (start + 3 >= iModelCount)
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
            start = start + 3;
            ModelsRefresh();
        }

        private void PreviousPgBtn_Click(object sender, EventArgs e)
        {
            start = start - 3;
            ModelsRefresh();
        }

        private void Model_Click(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todModelsDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[1] = currentFolderStructure.arrayOfModelsImages[int.Parse(me.Tag.ToString().Split(',')[0]) + start];
            BackendLogic.arrayOfOutputInfo[1] = currentFolderStructure.arrayOfModelsName[int.Parse(me.Tag.ToString().Split(',')[0]) + start];

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
                if (e.KeyCode == Keys.Space)
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

    }
}
