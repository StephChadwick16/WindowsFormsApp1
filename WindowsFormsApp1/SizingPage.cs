﻿using System;
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

            if (BackendLogic.inputOption == 1)
            {
                timerSwitch.Interval = BackendLogic.secondsTimer * 1000;
                timerSwitch.Enabled = true;
            }

            btnSize1.BackgroundImage = BackendLogic.arrayOfSizes[0];

            btnSize2.BackgroundImage = BackendLogic.arrayOfSizes[1];

            btnSize3.BackgroundImage = BackendLogic.arrayOfSizes[2];


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

        private void SizingPage_Load(object sender, EventArgs e)
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

        private void Size_Click1(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todSizesDone = DateTime.Now;
            BackendLogic.arrayOfOutputInfo[2] = SmallLabel.Text;
            BackendLogic.arrayOfOutputImage[2] = btnSize1.BackgroundImage;

            FinalPage newFinalPage = new FinalPage();
            newFinalPage.Show();
            Visible = false;
        }

        private void Size_Click2(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todSizesDone = DateTime.Now;
            BackendLogic.arrayOfOutputInfo[2] = MedLabel.Text;
            BackendLogic.arrayOfOutputImage[2] = btnSize2.BackgroundImage;

            FinalPage newFinalPage = new FinalPage();
            newFinalPage.Show();
            Visible = false;
        }

        private void Size_Click3(object sender, EventArgs e)
        {
            Button me = sender as Button;

            BackendLogic.todSizesDone = DateTime.Now;
            BackendLogic.arrayOfOutputInfo[2] = BigLabel.Text;
            BackendLogic.arrayOfOutputImage[2] = btnSize3.BackgroundImage;

            FinalPage newFinalPage = new FinalPage();
            newFinalPage.Show();
            Visible = false;
        }


        private void SmallLabel_Click(object sender, EventArgs e)
        {

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
                if (btnSize1 == ActiveControl) Size_Click1(sender, e);
                if (btnSize2 == ActiveControl) Size_Click2(sender, e);
                if (btnSize3 == ActiveControl) Size_Click3(sender, e);
            }

            if (e.KeyCode == Keys.Tab)
            {
                ctlCurr = ((Button)sender).Parent;
                ctlCurr.SelectNextControl(ActiveControl, true, true, true, true);
            }

        }


    }
}
