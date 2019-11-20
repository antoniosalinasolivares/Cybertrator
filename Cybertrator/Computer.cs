using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    public class Computer
    {
        private int id;
        private string name;
        private int money;
        private DateTime start;
        private bool busy;


        public Computer(int id, string name, int money)
        {
            this.Id = id;
            this.Name = name;
            this.Money = money;
            this.Busy = false;
            this.Start = new DateTime(0);
        }



        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Money { get => money; set => money = value; }
        public bool Busy { get => busy; set => busy = value; }
        public DateTime Start { get => start; set => start = value; }
    }
}
