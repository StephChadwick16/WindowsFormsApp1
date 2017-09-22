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

        public ModelsPage()
        {
            InitializeComponent();

           
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


    }
}
