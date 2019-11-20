using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cybertrator
{
    public partial class window_login : Form {

        Window_Dashboard ds = new Window_Dashboard();
        public window_login() {
            InitializeComponent();
            Start();
            State.Login = this;
        }

        private void btn_login_Click(object sender, EventArgs e) {
            Login();
        }

        private void Start() {
            State.Computers = FileLoader.GetComputers();
            State.Users = FileLoader.GetUsers();
        }

        private void Login() {
            bool success = false;
            User temp = new User(txtbox_user.Text, txtbox_password.Text);
            txtbox_password.Text = "";
            foreach (User user in State.Users)
            {
                success = success || User.Compare(temp, user);
            }
            if (success)
            {
                State.Current_user = temp;
                Manage();
            }
        }

        private void Manage() {
            
            Visible = false;
            Notify();
            ds.Visible = true;
            txtbox_user.Text = "";
        }

        private void Notify() {
            ds.renderUser();
            ds.renderComputers();
            ds.renderSales(); 
        }

        public void Show(bool b) {
            Visible = b;
        }
    }
}
