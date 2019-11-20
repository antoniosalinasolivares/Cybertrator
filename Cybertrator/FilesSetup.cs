using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    static class FilesSetup
    {
        readonly static string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cybertrator\\";
        readonly static string credsPath = FilesSetup.path + "creds.csv";
        readonly static string compsPath = FilesSetup.path + "comps.csv";
        readonly static string salesPath = FilesSetup.path + "sales.csv";
        readonly static string weeklySales = FilesSetup.path + "week.csv";

        public static string WeeklySales => WeeklySales1;

        public static string WeeklySales1 => weeklySales;

        static public void Run()
        {
            System.IO.Directory.CreateDirectory(FilesSetup.path);

            if (!File.Exists(FilesSetup.credsPath))
            {
                using FileStream fs_creds = File.Create(credsPath);
                byte[] info = new UTF8Encoding(true).GetBytes("user,password"+Environment.NewLine);
                fs_creds.Write(info, 0, info.Length);
            }
            if (!File.Exists(FilesSetup.compsPath))
            {
                using FileStream fs_comps = File.Create(compsPath);
                byte[] info = new UTF8Encoding(true).GetBytes("0,name,0");
                fs_comps.Write(info, 0, info.Length);
            }

            if (!File.Exists(FilesSetup.salesPath) || DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                using FileStream fs_sales = File.Create(salesPath);
                byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", DateTime.Now.Date.ToString(), Environment.NewLine));
                fs_sales.Write(info, 0, info.Length);
            }
            if (!File.Exists(FilesSetup.weeklySales) || DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                using FileStream fs_week = File.Create(WeeklySales);
                byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", "0", Environment.NewLine));
                fs_week.Write(info, 0, info.Length);
            }

           
        }

    }
}

