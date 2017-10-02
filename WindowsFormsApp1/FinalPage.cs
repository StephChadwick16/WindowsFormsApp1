using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRSSSNamespace
{
    public partial class FinalPage : Form
    {
        public FinalPage()
        {
            InitializeComponent();


            OptionSelected.Text = BackendLogic.inputOption.ToString();
            IntervalSelection.Text = BackendLogic.secondsTimer.ToString();
            StudentOption.Text = BackendLogic.studentName;

           
        }

        private void FinalPage_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StartPage openForm = new StartPage();
            openForm.Show();
            Visible = false;

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void SettingsAndTimesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BitmapSave(string FileName)
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(FileName, ImageFormat.Jpeg);

                bmp.Dispose();
            }
                        
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFinalPage = new SaveFileDialog();
            SaveFinalPage.Filter = "JPEG Files|*jpg.";
            SaveFinalPage.DefaultExt = "jpg";

            if (SaveFinalPage.ShowDialog(this) == DialogResult.OK)
            {
               BitmapSave(SaveFinalPage.FileName);

            }
            
        }
    }

}
