//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Timers;
//using System.Windows.Forms;
//using System.IO;
//using System.Diagnostics;

//namespace WindowsFormsApp1
//{
//    class PrthaPart
//    {

//        public System.Timers.Timer timer01;

//        public int currentBox = 0;

//        public Form1() : base()
//        {
//            InitializeComponent();

//            pictureBox1.BackColor = Color.Yellow;
//            pictureBox2.BackColor = Color.Black;
//            pictureBox3.BackColor = Color.Black;

//            this.KeyPreview = true;
//            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

//            // pictureBox1
//            // 
//            pictureBox1.Location = new System.Drawing.Point(46, 251);
//            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
//            pictureBox1.Name = "pictureBox1";
//            pictureBox1.Size = new System.Drawing.Size(288, 254);
//            pictureBox1.TabIndex = 1;
//            pictureBox1.TabStop = false;
//            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
//            // 
//            // pictureBox2
//            // 
//            pictureBox2.Location = new System.Drawing.Point(388, 251);
//            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
//            pictureBox2.Name = "pictureBox2";
//            pictureBox2.Size = new System.Drawing.Size(288, 254);
//            pictureBox2.TabIndex = 2;
//            pictureBox2.TabStop = false;
//            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
//            // 
//            // pictureBox3
//            // 
//            pictureBox3.Location = new System.Drawing.Point(723, 251);
//            pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
//            pictureBox3.Name = "pictureBox3";
//            pictureBox3.Size = new System.Drawing.Size(288, 254);
//            pictureBox3.TabIndex = 3;
//            pictureBox3.TabStop = false;
//            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
//            //

//            timer01 = new System.Timers.Timer(1000);

//            pictureBox1.Image = Image.FromFile("C:\\Users\\Prtha Singh\\Desktop\\Instruments.jpg");
//            pictureBox2.Image = Image.FromFile("C:\\Users\\Prtha Singh\\Desktop\\Models.jpg");
//            pictureBox3.Image = Image.FromFile("C:\\Users\\Prtha Singh\\Desktop\\Vehicles.jpg");


//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            timer01.Start();
//            timer01.Elapsed += new ElapsedEventHandler(OnTimedEvent);

//        }

//        // Specify what you want to happen when the Elapsed event is raised.
//        private void OnTimedEvent(object source, ElapsedEventArgs e)
//        {

//            if (currentBox == 0)
//            {
//                Color tempColor = pictureBox1.BackColor;
//                pictureBox1.BackColor = pictureBox2.BackColor;
//                pictureBox2.BackColor = tempColor;
//                currentBox = 1;
//                Debug.WriteLine(currentBox);
//            }

//            else if (currentBox == 1)
//            {
//                Color tempColor = pictureBox2.BackColor;
//                pictureBox2.BackColor = pictureBox3.BackColor;
//                pictureBox3.BackColor = tempColor;
//                currentBox = 2;
//                Debug.WriteLine(currentBox);
//            }

//            //
//            else if (currentBox == 2)
//            {
//                Color tempColor = pictureBox3.BackColor;
//                pictureBox3.BackColor = pictureBox1.BackColor;
//                pictureBox1.BackColor = tempColor;
//                currentBox = 0;
//                Debug.WriteLine(currentBox);
//            }

//        }

//        private void timer1_Tick(object sender, EventArgs e)
//        {

//        }

//        void Form1_KeyUp(object sender, KeyEventArgs e)
//        {
//            if (currentBox == 0)
//            {
//                pictureBox4.BackColor = Color.Yellow;
//            }
//            else if (currentBox == 1)
//            {
//                pictureBox4.BackColor = Color.Green;
//            }
//            else if (currentBox == 2)
//            {
//                pictureBox4.BackColor = Color.Black;
//            }

//            timer01.Stop();
//        }


//        private void pictureBox1_Click(object sender, EventArgs e)
//        {
//            pictureBox4.BackColor = Color.Yellow;
//        }

//        private void pictureBox2_Click(object sender, EventArgs e)
//        {
//            pictureBox4.BackColor = Color.Green;
//        }

//        private void pictureBox3_Click(object sender, EventArgs e)
//        {
//            pictureBox4.BackColor = Color.Black;
//        }


//    }
//}

