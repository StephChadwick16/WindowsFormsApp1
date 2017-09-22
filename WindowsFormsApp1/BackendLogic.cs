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

        // Need to work out how to get images dynamically but still keep them in sets of three 
        public static Image[] arrayOfCategoriesImages;
        public static Image[] arrayOfModelsImages;


        public static Image[] arrayOfColours = new Image[7];
        public static Image[] arrayOfSizes = new Image[3];

        public static string[] arrayOfCategoriesName;
        public static string[] arrayOfModelsName;

        public static DirectoryInfo currentDir;


        public static void SetupApp()
        {

            studentName = "error";
            secondsTimer = 0;
            inputOption = -1;

            currentDir = new DirectoryInfo(Directory.GetCurrentDirectory());

            CountFilesCategoriesFolder();
            CountFilesModelsFolders();
            ColourSelect();
            SizeSelect();

        }


        
        public static void CountFilesCategoriesFolder()
        {
            // Count Files in Folder//
            string folder = "//Categories";
            string[] files = Directory.GetFiles(currentDir.ToString() + folder);
            int fileCount = Directory.GetFiles(currentDir.ToString() + folder).Length;

            arrayOfCategoriesName = new string[fileCount];
            arrayOfCategoriesImages = new Image[fileCount];
            
            // Getting the names for the files//

            for (int numFiles = 0; numFiles < fileCount; numFiles++)
            {
                string fileName = files[numFiles]; //This grabs path for file//
                string lastWord = fileName.Trim().Split('\\').LastOrDefault();
                string final = lastWord.Split('.').FirstOrDefault();

                arrayOfCategoriesName[numFiles] = final;

                arrayOfCategoriesImages[numFiles] = Image.FromFile(fileName);

               
            }
        }

        public static void CountFilesModelsFolders()
        {

            // Count Files in Folder//
            string folder = "\\Categories\\Category Models";
            string[] files = Directory.GetDirectories(currentDir.ToString() + folder);
            int fileModelsCount = files.Length;
            

            arrayOfModelsName = new string[fileModelsCount];
            arrayOfModelsImages = new Image[fileModelsCount];

            // Getting the names for the files//

            for (int numFiles = 0; numFiles < fileModelsCount; numFiles++)
            {
                string fileName = files[numFiles]; //This grabs path for file//
                string lastWord = fileName.Trim().Split('\\').LastOrDefault();
                string final = lastWord.Split('.').FirstOrDefault();

                arrayOfModelsName[numFiles] = final;

               //arrayOfModelsImages[numFiles] = Image.FromFile(fileName);

                Debug.WriteLine(final);



            }
        }

            public static void ColourSelect()
        {
            FileInfo ColourFile;

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Blue.jpg");
            arrayOfColours[0] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Green.jpg");
            arrayOfColours[1] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Orange.jpg");
            arrayOfColours[2] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Pink.jpg");
            arrayOfColours[3] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Purple.jpg");
            arrayOfColours[4] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Red.jpg");
            arrayOfColours[5] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Yellow.jpg");
            arrayOfColours[6] = Image.FromFile(ColourFile.ToString());

        }

        public static void SizeSelect()
        {

            FileInfo SizeFile;

            SizeFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Sizes\\Small.jpg");
            arrayOfSizes[0] = Image.FromFile(SizeFile.ToString());

            SizeFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Sizes\\Medium.jpg");
            arrayOfSizes[1] = Image.FromFile(SizeFile.ToString());

            SizeFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Sizes\\Big.jpg");
            arrayOfSizes[2] = Image.FromFile(SizeFile.ToString());

        }

       
        
    }


}