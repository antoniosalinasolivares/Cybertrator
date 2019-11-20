  using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    static class FileLoader
    {
        //Paths to look at the files created by FileSetup
        private readonly static string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cybertrator\\";
        private readonly static string credsPath = FileLoader.path + "creds.csv";
        private readonly static string compsPath = FileLoader.path + "comps.csv";
        private readonly static string salesPath = FileLoader.path + "sales.csv";
        private readonly static string weeklySales = FileLoader.path + "week.csv";


        //auxiliary lists to hold the users computers
        public static List<User> users = new List<User>();
        public static List<Computer> computers = new List<Computer>();
        public static List<String> sales = new List<String>();
        public static double weeklybalance = 0;


        //These methods open the paths to load the users and computers, adding them to the temporary list
        //the creds.csv file contains users and passwords (non encrypted) as: user,password they are both loaded as strings
        //the comps.csv file contains computers, id's and money generated as: id,name,money the values id and money get parsed 
        private static void LoadUsers()
        {
            FilesSetup.Run();
            using StreamReader sr = File.OpenText(credsPath);
            string s = "";
            string[] temp, sep = { "," };

            while ((s = sr.ReadLine()) != null)
            {
                string[] v = temp = s.Split(sep, 2, StringSplitOptions.RemoveEmptyEntries);
                FileLoader.users.Add(new User(v[0], v[1]));
            }
        }

        private static void LoadComputers()
        {
            using StreamReader sr = File.OpenText(compsPath);
            string s = "";
            string[] temp, sep = { "," };

            while ((s = sr.ReadLine()) != null)
            {
                string[] v = temp = s.Split(sep, 3, StringSplitOptions.RemoveEmptyEntries);
                FileLoader.computers.Add(new Computer(int.Parse(v[0]), v[1], int.Parse(v[2])));
            }
        }

        private static void LoadSales() 
        {
            using StreamReader sr = File.OpenText(salesPath);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                sales.Add(s);
            }
        }

        private static void LoadWeeklySales()
        {
            using StreamReader sr = File.OpenText(weeklySales);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                weeklybalance = Double.Parse(s);
            }
        }


        //These methods use the previous methods to load the persistent data 
        //and return the complete lists of computers and users

        public static Double getWeeklyBalance() 
        {
            LoadWeeklySales();
            return weeklybalance;
        }

        public static List<User> GetUsers()
        {
            FileLoader.LoadUsers();
            return FileLoader.users;
        }
        public static List<Computer> GetComputers()
        {
            FileLoader.LoadComputers();
            return FileLoader.computers;
        }
        public static List<String> GetSales()
        {
            FileLoader.LoadSales();
            return FileLoader.sales;
        }
    }
 }
