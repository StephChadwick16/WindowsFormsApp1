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


        public static Image[] arrayOfCategoriesImages;
        public static Image[] arrayOfModelsImages;
        

        public static Image[] arrayOfColours = new Image[8];
        public static Image[] arrayOfSizes = new Image[3];

        public static string[] arrayOfSizesName;
        public static string[] arrayOfColoursName;

        public static string[] arrayOfCategoriesName;
        public static string[] arrayOfModelsName;

        public static string[] arrayOfOutputInfo;
        public static Image[] arrayOfOutputImage;

        public static DirectoryInfo currentDir;

        public static int numOfFiles = 0;

        public static void SetupApp()
        {

            studentName = "error";
            secondsTimer = 0;
            inputOption = -1;
            arrayOfOutputInfo = new string[4];
            arrayOfOutputImage = new Image[4];

            currentDir = new DirectoryInfo(Directory.GetCurrentDirectory());

            CountFilesCategoriesFolder();

            ColourSelect();
            SizeSelect();

        }



        public static void CountFilesCategoriesFolder()
        {
            // Count Files in Folder//
            string folder = "\\Categories";
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

        
        public static FolderStructure CountFilesModelsFolders(string folder)
        {

            FolderStructure OutputOfFolders = new FolderStructure();

            string[] directories = Directory.GetDirectories(currentDir.ToString() + folder);
            int fileDirectoriesCount = directories.Length;
            numOfFiles = 0;

            string[] arrayOfDirectoriesName = new string[fileDirectoriesCount];

            // Getting the names for the files//

            for (int numFolders = 0; numFolders < fileDirectoriesCount; numFolders++)
            {
                string folderName = directories[numFolders]; //This grabs path for file//
                string lastWord = folderName.Trim().Split('\\').LastOrDefault();
                string final = lastWord.Split('.').LastOrDefault();

                numOfFiles++;

                //Debug.WriteLine(final);

            }

            string[] files = Directory.GetFiles(currentDir.ToString() + folder);
            int fileCount = Directory.GetFiles(currentDir.ToString() + folder).Length;

            OutputOfFolders.arrayOfModelsName = new string[fileCount];
            OutputOfFolders.arrayOfModelsImages = new Image[fileCount];

            // Getting the names for the files//

            for (int numFiles = 0; numFiles < fileCount; numFiles++)
            {
                string fileName = files[numFiles]; //This grabs path for file//
                string lastWord = fileName.Trim().Split('\\').LastOrDefault();
                string final = lastWord.Split('.').FirstOrDefault();

                OutputOfFolders.arrayOfModelsName[numFiles] = final;

                OutputOfFolders.arrayOfModelsImages[numFiles] = Image.FromFile(fileName);

                Debug.WriteLine(arrayOfOutputInfo[1]);
            }

            return OutputOfFolders;

        }

        public struct FolderStructure
        {
            public string[] arrayOfDirectoriesName, arrayOfModelsName;
            public Image[] arrayOfModelsImages;

        }


        public static void ColourSelect()
        {
            FileInfo ColourFile;

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Black.jpg");
            arrayOfColours[0] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Blue.jpg");
            arrayOfColours[1] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Green.jpg");
            arrayOfColours[2] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Orange.jpg");
            arrayOfColours[3] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Pink.jpg");
            arrayOfColours[4] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Purple.jpg");
            arrayOfColours[5] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Red.jpg");
            arrayOfColours[6] = Image.FromFile(ColourFile.ToString());

            ColourFile = new FileInfo(currentDir.Parent.Parent.FullName + "\\bin\\Debug\\Colours\\Yellow.jpg");
            arrayOfColours[7] = Image.FromFile(ColourFile.ToString());

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