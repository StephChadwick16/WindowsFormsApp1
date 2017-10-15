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
        //private int start = 0;
        private int currentSubPart = 0;


        public SubPartsPage()
        {
            InitializeComponent();

            path = ".\\Categories\\Category Models\\" + BackendLogic.arrayOfOutputInfo[0] + "\\" + BackendLogic.arrayOfOutputInfo[1];
            //path = string.Format(".\\Categories\\Category Models\\{0}\\{1}", BackendLogic.arrayOfOutputInfo[0], BackendLogic.arrayOfOutputInfo[1]);

            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Interval = BackendLogic.secondsTimer * 1000;
                timerSwitch.Enabled = true;
            }

            foreach (var file in Directory.EnumerateFiles(path, "*"))
            {
                FileInfo fi = new FileInfo(file);
                Image img = Image.FromFile(file);
                BackendLogic.arrayOfSPImage.Add(img);
                BackendLogic.arrayOfSPInfo.Add(fi.Name);
            }


            btnColour1.BackgroundImage = BackendLogic.arrayOfColours[0];
            
            btnColour2.BackgroundImage = BackendLogic.arrayOfColours[1];
            
            btnColour3.BackgroundImage = BackendLogic.arrayOfColours[2];
            
            btnColour4.BackgroundImage = BackendLogic.arrayOfColours[3];
            
            btnColour5.BackgroundImage = BackendLogic.arrayOfColours[4];
            
            btnColour6.BackgroundImage = BackendLogic.arrayOfColours[5];
            
            btnColour7.BackgroundImage = BackendLogic.arrayOfColours[6];
            
            btnColour8.BackgroundImage = BackendLogic.arrayOfColours[7];
            

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
            BackendLogic.todColoursDone = DateTime.Now;
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

        private void Colour_Click1(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(0);
        }

        private void Colour_Click2(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(1);
        }

        private void Colour_Click3(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(2);
        }

        private void Colour_Click4(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(3);
        }

        private void Colour_Click5(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(4);
        }

        private void Colour_Click6(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(5);
        }

        private void Colour_Click7(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(6);
        }

        private void Colour_Click8(object sender, EventArgs e)
        {
            Button me = sender as Button;
            SelectColour(7);
        }



        private void butSelection_Enter(object sender, EventArgs e)
        {
            ((Button)sender).FlatAppearance.BorderColor = Color.Aqua;
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

    }
}
