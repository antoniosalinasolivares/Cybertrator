using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cybertrator
{
    public partial class Window_Dashboard : Form
    {
        Computer current = null;
        Double todaySales = 0, weeklySales = FileLoader.getWeeklyBalance();
        public Window_Dashboard()
        {
            InitializeComponent();
            LoadSales();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            State.Current_user = State.NO_USER;
            Visible = false;
            State.Login.Show(true);
        }

        public void renderUser() {
            lbl_username.Text = "Bienvenido: " + State.Current_user.Name;
        }

        private void list_computer_SelectedIndexChanged(object sender, EventArgs e){
            string selected_text = list_computer.GetItemText(list_computer.SelectedItem);
            foreach (Computer computer in State.Computers)
            {
                if (computer.Name == selected_text)
                {
                    current = computer;
                }
            }
            displaycurrentInfo();
        }

        public void renderComputers() {
            foreach (Computer computer in State.Computers)
            {
                list_computer.Items.Add(computer.Name);
            }
        }

        public void renderSales() 
        {
            foreach (string sale in FileLoader.GetSales())
            {
                listbox_sales.Items.Add(sale);
            }
        }
 
        private void displaycurrentInfo()
        {
            if (current.Busy)
            {
                DateTime now = DateTime.UtcNow;
                TimeSpan diff = now - 
                    current.Start;
                double costo = diff.TotalMinutes * 8 / 60;
                txt_LockedTime.Text = current.Start.ToString();
                txt_elapsedTime.Text = diff.TotalMinutes.ToString();
                txt_cost.Text = costo.ToString();
                lbl_busy.Text = "Ocupada";
                btn_enable.Text = "Terminar";
            }
            else 
            {
                txt_elapsedTime.Text = "";
                txt_LockedTime.Text = "";
                txt_cost.Text = "";
                lbl_busy.Text = "Disponible";
                btn_enable.Text = "Activar";
            }
            
            lbl_weeklySales.Text = "Ventas de la Semana: $" + weeklySales.ToString();
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            if (current.Busy)
            {
                current.Busy = false;
                processSale();
                displaycurrentInfo();

            }
            else 
            {
                current.Busy = true;
                current.Start = DateTime.UtcNow;
                displaycurrentInfo();
            }
        }

        private void processSale()
        {
            string sale = State.Current_user.Name + " " + current.Name + "    $" + Math.Round(Double.Parse(txt_cost.Text), 2);
            todaySales += Math.Round(Double.Parse(txt_cost.Text), 2);
            weeklySales += Math.Round(Double.Parse(txt_cost.Text), 2);
            lbl_todaySales.Text = "Ventas de hoy: $" + todaySales;
            FileWriter.saveWeeklyBalance(weeklySales.ToString());
            listbox_sales.Items.Add(sale);
            FileWriter.saveSale(sale);
            LoadSales();
        }

        private void btn_addComputer_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Nombre de la maquina", "Introduce");
            if (!(promptValue == ""))
            {
                State.Computers.Add(new Computer(0, promptValue, 0));
                FileWriter.saveComputer(new Computer(0, promptValue, 0));
                list_computer.Items.Clear();
                renderComputers();
            }
        }

        private void btn_deleteComputer_Click(object sender, EventArgs e)
        {
            State.Computers.Remove(current);
            FileWriter.saveComputers();
            list_computer.Items.Clear();
            renderComputers();
        }

        private void btn_deleteCurrentUser_Click(object sender, EventArgs e)
        {
            List<User> newUsers = new List<User>();
            foreach (User user in State.Users) 
            {
                if(!User.Compare(user, State.Current_user))
                {
                    newUsers.Add(user);
                }       
            }
            State.Users = newUsers;
            FileWriter.saveUsers();
            State.Current_user = State.NO_USER;
            Visible = false;
            State.Login.Show(true);
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            string username = Prompt.ShowDialog("Nombre de usuario", "Introduce");
            string password = Prompt.ShowDialog("contraseña", "Introduce");
            if ((username != "") && (password != ""))
            {
                User user = new User(username, password);
                State.Users.Add(user);
                FileWriter.saveUser(user);
            }
        }

        private void LoadSales()
        {
            lbl_weeklySales.Text = "Ventas de la Semana: $" + weeklySales.ToString();
        }
    }
}