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

        public CategoryPage()
        {
            InitializeComponent();

            OptionSelected.Text = BackendLogic.inputOption.ToString();
            IntervalSelection.Text = BackendLogic.secondsTimer.ToString();
            StudentOption.Text = BackendLogic.studentName;

            pictureBox1.Image = BackendLogic.arrayOfImages[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = BackendLogic.arrayOfImages[1];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.Image = BackendLogic.arrayOfImages[2];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionSelected_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ModelsPage openForm = new ModelsPage();
            openForm.Show();
            Visible = false;

        }
    }
}
