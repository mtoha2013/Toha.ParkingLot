using System;
using System.IO;

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
