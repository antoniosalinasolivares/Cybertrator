﻿using System;
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
        readonly static string credsPath = path + "creds.csv";
        readonly static string compsPath = path + "comps.csv";
        readonly static string salesPath = path + "sales.csv";
        readonly static string weeklySales = path + "week.csv";

        public static string WeeklySales => WeeklySales1;

        public static string WeeklySales1 => weeklySales;

        static public void Run()
        {
            System.IO.Directory.CreateDirectory(FilesSetup.path);

            if (!File.Exists(FilesSetup.credsPath))
            {
                using FileStream fs_creds = File.Create(credsPath);
                byte[] info = new UTF8Encoding(true).GetBytes("admin,admin"+Environment.NewLine);
                fs_creds.Write(info, 0, info.Length);
            }
            if (!File.Exists(FilesSetup.compsPath))
            {
                using FileStream fs_comps = File.Create(compsPath);
                byte[] info = new UTF8Encoding(true).GetBytes("0,name,0"+Environment.NewLine);
                fs_comps.Write(info, 0, info.Length);
            }

            if (!File.Exists(FilesSetup.salesPath))
            {
                using FileStream fs_comps = File.Create(salesPath);
                byte[] info = new UTF8Encoding(true).GetBytes("");
                fs_comps.Write(info, 0, info.Length);
            }

            if (File.Exists(FilesSetup.salesPath) || DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                using FileStream fs_sales = File.Create(salesPath);
                byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", "", Environment.NewLine));
                fs_sales.Write(info, 0, info.Length);
                fs_sales.Close();
            }
            if (File.Exists(FilesSetup.weeklySales) || DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                using FileStream fs_week = File.Create(salesPath);
                byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", "0", Environment.NewLine));
                fs_week.Write(info, 0, info.Length);
                fs_week.Close();
            }


        }

    }
}

