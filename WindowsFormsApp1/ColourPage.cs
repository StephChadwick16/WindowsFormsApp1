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
            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Interval = BackendLogic.secondsTimer * 1000;
                timerSwitch.Enabled = true;
            }

            btnColour1.BackgroundImage = BackendLogic.arrayOfColours[0];

            btnColour2.BackgroundImage = BackendLogic.arrayOfColours[1];

            btnColour3.BackgroundImage = BackendLogic.arrayOfColours[2];

            btnColour4.BackgroundImage = BackendLogic.arrayOfColours[3];

            btnColour5.BackgroundImage = BackendLogic.arrayOfColours[4];

            btnColour6.BackgroundImage = BackendLogic.arrayOfColours[5];

            btnColour7.BackgroundImage = BackendLogic.arrayOfColours[6];

            btnColour8.BackgroundImage = BackendLogic.arrayOfColours[7];


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                // Process keys
                return true;
            }

            if (keyData == Keys.Space)
            {
                // Process keys
                return true;
            }


            if (keyData == Keys.Enter)
            {
                // Process keys
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
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


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }

        private void Colour_Click1(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour1.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click2(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour2.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click3(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour3.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click4(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour4.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click5(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour5.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click6(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour6.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click7(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour7.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
            Visible = false;


        }
        private void Colour_Click8(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todColoursDone = DateTime.Now;
            BackendLogic.arrayOfOutputImage[3] = btnColour8.BackgroundImage;

            SizingPage newSizingPage = new SizingPage();
            newSizingPage.Show();
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

       
        private void butSelection_KeyUp(object sender, KeyEventArgs e)
        {
            Control ctlCurr;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                if (btnColour1 == ActiveControl) Colour_Click1(sender, e);
                if (btnColour2 == ActiveControl) Colour_Click2(sender, e);
                if (btnColour3 == ActiveControl) Colour_Click3(sender, e);
                if (btnColour4 == ActiveControl) Colour_Click4(sender, e);
                if (btnColour5 == ActiveControl) Colour_Click5(sender, e);
                if (btnColour6 == ActiveControl) Colour_Click6(sender, e);
                if (btnColour7 == ActiveControl) Colour_Click7(sender, e);
                if (btnColour8 == ActiveControl) Colour_Click8(sender, e);
            }

            if (e.KeyCode == Keys.Tab)
            {
                ctlCurr = ((Button)sender).Parent;
                ctlCurr.SelectNextControl(ActiveControl, true, true, true, true);
            }


        }


    }
}
