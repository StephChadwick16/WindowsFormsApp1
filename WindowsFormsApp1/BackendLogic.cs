using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace NRSSSNamespace
{

    public static class BackendLogic
    {

        public static string studentName;
        public static int secondsTimer;
        public static int inputOption;

        public static Image[] arrayOfImages = new Image[3]; 


        public static void SetupApp()
        {
            studentName = "error";
            secondsTimer = 0;
            inputOption = -1;

            arrayOfImages[0] = Image.FromFile("Instruments.jpg");
            arrayOfImages[1] = Image.FromFile("Models.jpg");
            arrayOfImages[2] = Image.FromFile("Vehicles.jpg");

            //Debug.WriteLine("____----____" + Directory.GetCurrentDirectory());


        }

        
        public static Image[] ImageArray = new Image[6];

        public static void ColourSelect()
        {

            ImageArray[0] = Image.FromFile("Blue.jpg");
            ImageArray[1] = Image.FromFile("Yellow.jpg");
            ImageArray[2] = Image.FromFile("Green.jpg");
            ImageArray[3] = Image.FromFile("Red.jpg");
            ImageArray[4] = Image.FromFile("Orange.jpg");
            ImageArray[5] = Image.FromFile("Pink.jpg");
            ImageArray[6] = Image.FromFile("Purple.jpg");


        }

            
        



    }


}
