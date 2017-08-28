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

    public partial class StartPage : Form
    {

        /// <summary>
        /// Summary of what is included on the settings page - inputting child's name into the textbox, 
        /// indicating intervals (seconds timer) and determining input option for the controls of the program
        /// </summary>
        public StartPage()
        {
            InitializeComponent();

            BackendLogic.SetupApp();

            StuffAndThingsEnablement(false);
        }

        private void NRSSS_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BackendLogic.studentName = ChildNameTextbox.Text;

            CategoryPage newCategoryPage = new CategoryPage();
            newCategoryPage.Show();
            Visible = false;


        }

        private void Interval10Sec_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 10;
        }

        private void Interval20Sec_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 20;
        }

        private void Interval30Sec_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 30;
        }

        private void Interval1Min_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 60;
        }

        private void Interval1HalfMin_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 90;
        }

        private void Interval2Min_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 120;
        }

        private void Interval5Min_CheckedChanged(object sender, EventArgs e)
        {
            BackendLogic.secondsTimer = 300;
        }

        private void StuffAndThingsEnablement(bool status)
        {
            Interval10Sec.Visible = status;
            Interval20Sec.Visible = status;
            Interval30Sec.Visible = status;
            Interval1Min.Visible = status;
            Interval1HalfMin.Visible = status;
            Interval2Min.Visible = status;
            Interval5Min.Visible = status;
        }

        private void InputOption1_CheckedChanged_1(object sender, EventArgs e)
        {
            StuffAndThingsEnablement(true);
            BackendLogic.inputOption = 1;
        }

        private void InputOption2_CheckedChanged(object sender, EventArgs e)
        {
            StuffAndThingsEnablement(false);
            BackendLogic.inputOption = 2;
        }

        private void InputOption3_CheckedChanged(object sender, EventArgs e)
        {
            StuffAndThingsEnablement(false);
            BackendLogic.inputOption = 3;
        }
    }
}
