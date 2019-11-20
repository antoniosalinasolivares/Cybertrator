using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    public class User
    {
        private String name;
        private String password;

        public User(string name, string password)
        {
            this.Name = new String(name.ToCharArray());
            this.Password = new String(password.ToCharArray());
        }

        public static bool Compare(User u1, User u2)
        {
            return u1.name.Equals(u2.name) && u1.password.Equals(u2.password);
        }

        public bool Equals(User u2) 
        {
            return this.name.Equals(u2.name) && this.password.Equals(u2.password);
        }

        public String Name { get => name; set => name = value; }
        public String Password { get => password; set => password = value; }
    }
}
