using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRSSSNamespace
{

    public static class BackendLogic
    {

        public static string studentName;
        public static int secondsTimer;
        public static int inputOption;

        public static void SetupApp()
        {
            studentName = "error";
            secondsTimer = 0;
            inputOption = -1;
        }

    }


}
