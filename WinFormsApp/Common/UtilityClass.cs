using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormsApp.Common
{
    class UtilityClass
    {
        internal static void LogToFile(string ErrorMessage)
        {

            using (StreamWriter w = File.AppendText("logFile.txt"))
            {
                w.WriteLine(string.Format("error on {0}: {1}", DateTime.Now.ToString(), ErrorMessage));
            }
        }
    }
}
