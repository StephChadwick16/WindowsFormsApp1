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

        public static Image[] arrayOfCategories = new Image[3];
        public static Image[] arrayOfColours = new Image[7];

        public static DirectoryInfo currentDir;

        public static void SetupApp()
        {
            studentName = "error";
            secondsTimer = 0;
            inputOption = -1;

            currentDir = new DirectoryInfo(Directory.GetCurrentDirectory());

            //Debug.WriteLine("____----____" + Directory.GetCurrentDirectory());
            CategorySelect();
            ColourSelect();

        }

        public static void CategorySelect()
        {
            FileInfo myFile;

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Categories\\Instruments.jpg");
            arrayOfCategories[0] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Categories\\Models.jpg");
            arrayOfCategories[1] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Categories\\Vehicles.jpg");
            Debug.WriteLine(myFile.ToString());
            arrayOfCategories[2] = Image.FromFile(myFile.ToString());

        }

        public static void ColourSelect()
        {
            FileInfo myFile;

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Blue.jpg");
            arrayOfColours[0] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Green.jpg");
            arrayOfColours[1] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Orange.jpg");
            arrayOfColours[2] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Pink.jpg");
            arrayOfColours[3] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Purple.jpg");
            arrayOfColours[4] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Red.jpg");
            arrayOfColours[5] = Image.FromFile(myFile.ToString());

            myFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Yellow.jpg");
            Debug.WriteLine(myFile.ToString());
            arrayOfColours[6] = Image.FromFile(myFile.ToString());



        }






    }


}