using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybertrator
{
    public static class State
    {
        private static readonly User nO_USER = new User("", "");
        private static List<Computer> computers = null;
        private static List<User> users = null;
        private static User current_user = State.NO_USER;
        private static bool managing = false;
        private static window_login login = null;

        public static List<Computer> Computers { get => computers; set => computers = value; }
        public static List<User> Users { get => users; set => users = value; }
        public static User NO_USER => nO_USER;
        public static User Current_user { get => current_user; set => current_user = value; }
        public static bool Managing { get => managing; set => managing = value; }
        public static window_login Login { get => login; set => login = value; }
    }
}
