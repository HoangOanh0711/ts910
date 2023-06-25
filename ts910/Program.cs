using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ts910.ChatBox;

namespace ts910
{
    static class Program
    {
        public static string filePathExcel = "D:\\Project\\c#\\ts910\\ts910\\data.xlsx";
        //public static string filePathExcel = "E:\\STUDY\\C#\\LT\\ts910\\ts910\\data.xlsx";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new dang_nhap());

        }
    }
}
