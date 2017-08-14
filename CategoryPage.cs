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

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
