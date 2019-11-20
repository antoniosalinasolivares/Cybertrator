using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    static class FileWriter
    {
        private readonly static string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cybertrator\\";
        private readonly static string credsPath = FileWriter.path + "creds.csv";
        private readonly static string compsPath = FileWriter.path + "comps.csv";
        private readonly static string salesPath = FileWriter.path + "sales.csv";
        private readonly static string weeklySalesPath = FileWriter.path + "week.csv";

        public static void saveComputers()
        {
            using FileStream fs_comps = File.Create(compsPath);
            byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", "", ""));
            fs_comps.Write(info, 0, info.Length);
            fs_comps.Close();
            foreach (Computer computer in State.Computers)
            {
                saveComputer(computer);
            }
        }

        public static void saveComputer(Computer computer)
        {
            File.AppendAllText(compsPath, string.Format("{0}{1}",computer.Id.ToString()+","+computer.Name+",0", Environment.NewLine));
        }

        public static void saveUsers()
        {
            using FileStream fs_creds = File.Create(credsPath);
            byte[] info = new UTF8Encoding(true).GetBytes(string.Format("{0}{1}", "", ""));
            fs_creds.Write(info, 0, info.Length);
            fs_creds.Close();
            foreach (User user in State.Users)
            {
                saveUser(user);
            }
        }

        public static void saveUser(User user)
        {
            File.AppendAllText(credsPath, string.Format("{0}{1}", user.Name + "," +user.Password, Environment.NewLine));
        }

        public static void saveSale(string sale) 
        {
            File.AppendAllText(salesPath, string.Format("{0}{1}", sale , Environment.NewLine));
        }

        public static void saveWeeklyBalance(string sale)
        {
            File.AppendAllText(weeklySalesPath, string.Format("{0}{1}", sale, Environment.NewLine));
        }
    }
}
