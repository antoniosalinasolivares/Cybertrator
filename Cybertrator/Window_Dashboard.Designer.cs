namespace Cybertrator
{
    partial class Window_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.list_computer = new System.Windows.Forms.ListBox();
            this.txt_LockedTime = new System.Windows.Forms.TextBox();
            this.txt_elapsedTime = new System.Windows.Forms.TextBox();
            this.lbl_LockedTime = new System.Windows.Forms.Label();
            this.lbl_elapsedTime = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.btn_enable = new System.Windows.Forms.Button();
            this.lbl_busy = new System.Windows.Forms.Label();
            this.lbl_log = new System.Windows.Forms.Label();
            this.lbl_computerList = new System.Windows.Forms.Label();
            this.lbl_todaySales = new System.Windows.Forms.Label();
            this.lbl_weeklySales = new System.Windows.Forms.Label();
            this.listbox_sales = new System.Windows.Forms.ListBox();
            this.btn_deleteCurrentUser = new System.Windows.Forms.Button();
            this.btn_deleteComputer = new System.Windows.Forms.Button();
            this.btn_addComputer = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(682, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(106, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Cerrar Sesion";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(560, 15);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(11, 16);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = ".";
            // 
            // list_computer
            // 
            this.list_computer.FormattingEnabled = true;
            this.list_computer.Location = new System.Drawing.Point(12, 38);
            this.list_computer.Name = "list_computer";
            this.list_computer.Size = new System.Drawing.Size(170, 394);
            this.list_computer.TabIndex = 2;
            this.list_computer.SelectedIndexChanged += new System.EventHandler(this.list_computer_SelectedIndexChanged);
            // 
            // txt_LockedTime
            // 
            this.txt_LockedTime.Enabled = false;
            this.txt_LockedTime.Location = new System.Drawing.Point(188, 63);
            this.txt_LockedTime.Name = "txt_LockedTime";
            this.txt_LockedTime.Size = new System.Drawing.Size(130, 20);
            this.txt_LockedTime.TabIndex = 3;
            // 
            // txt_elapsedTime
            // 
            this.txt_elapsedTime.Enabled = false;
            this.txt_elapsedTime.Location = new System.Drawing.Point(188, 111);
            this.txt_elapsedTime.Name = "txt_elapsedTime";
            this.txt_elapsedTime.Size = new System.Drawing.Size(130, 20);
            this.txt_elapsedTime.TabIndex = 4;
            // 
            // lbl_LockedTime
            // 
            this.lbl_LockedTime.AutoSize = true;
            this.lbl_LockedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LockedTime.Location = new System.Drawing.Point(188, 44);
            this.lbl_LockedTime.Name = "lbl_LockedTime";
            this.lbl_LockedTime.Size = new System.Drawing.Size(109, 16);
            this.lbl_LockedTime.TabIndex = 5;
            this.lbl_LockedTime.Text = "Ocupada desde:";
            // 
            // lbl_elapsedTime
            // 
            this.lbl_elapsedTime.AutoSize = true;
            this.lbl_elapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_elapsedTime.Location = new System.Drawing.Point(188, 92);
            this.lbl_elapsedTime.Name = "lbl_elapsedTime";
            this.lbl_elapsedTime.Size = new System.Drawing.Size(102, 16);
            this.lbl_elapsedTime.TabIndex = 6;
            this.lbl_elapsedTime.Text = "Tiempo de uso:";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(188, 144);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(46, 16);
            this.lbl_cost.TabIndex = 8;
            this.lbl_cost.Text = "Costo:";
            // 
            // txt_cost
            // 
            this.txt_cost.Enabled = false;
            this.txt_cost.Location = new System.Drawing.Point(188, 163);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(130, 20);
            this.txt_cost.TabIndex = 7;
            // 
            // btn_enable
            // 
            this.btn_enable.Location = new System.Drawing.Point(188, 198);
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Size = new System.Drawing.Size(75, 23);
            this.btn_enable.TabIndex = 9;
            this.btn_enable.Text = " ";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_Click);
            // 
            // lbl_busy
            // 
            this.lbl_busy.AutoSize = true;
            this.lbl_busy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busy.Location = new System.Drawing.Point(188, 15);
            this.lbl_busy.Name = "lbl_busy";
            this.lbl_busy.Size = new System.Drawing.Size(11, 16);
            this.lbl_busy.TabIndex = 10;
            this.lbl_busy.Text = ".";
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log.Location = new System.Drawing.Point(373, 15);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(124, 16);
            this.lbl_log.TabIndex = 12;
            this.lbl_log.Text = "Registro de ventas:";
            // 
            // lbl_computerList
            // 
            this.lbl_computerList.AutoSize = true;
            this.lbl_computerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerList.Location = new System.Drawing.Point(12, 15);
            this.lbl_computerList.Name = "lbl_computerList";
            this.lbl_computerList.Size = new System.Drawing.Size(124, 16);
            this.lbl_computerList.TabIndex = 14;
            this.lbl_computerList.Text = "Registro de ventas:";
            // 
            // lbl_todaySales
            // 
            this.lbl_todaySales.AutoSize = true;
            this.lbl_todaySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_todaySales.Location = new System.Drawing.Point(373, 416);
            this.lbl_todaySales.Name = "lbl_todaySales";
            this.lbl_todaySales.Size = new System.Drawing.Size(97, 16);
            this.lbl_todaySales.TabIndex = 15;
            this.lbl_todaySales.Text = "Ventas de hoy:";
            // 
            // lbl_weeklySales
            // 
            this.lbl_weeklySales.AutoSize = true;
            this.lbl_weeklySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weeklySales.Location = new System.Drawing.Point(582, 416);
            this.lbl_weeklySales.Name = "lbl_weeklySales";
            this.lbl_weeklySales.Size = new System.Drawing.Size(140, 16);
            this.lbl_weeklySales.TabIndex = 16;
            this.lbl_weeklySales.Text = "Ventas de la Semana:";
            // 
            // listbox_sales
            // 
            this.listbox_sales.FormattingEnabled = true;
            this.listbox_sales.Location = new System.Drawing.Point(376, 38);
            this.listbox_sales.Name = "listbox_sales";
            this.listbox_sales.Size = new System.Drawing.Size(283, 355);
            this.listbox_sales.TabIndex = 17;
            // 
            // btn_deleteCurrentUser
            // 
            this.btn_deleteCurrentUser.Location = new System.Drawing.Point(682, 370);
            this.btn_deleteCurrentUser.Name = "btn_deleteCurrentUser";
            this.btn_deleteCurrentUser.Size = new System.Drawing.Size(106, 23);
            this.btn_deleteCurrentUser.TabIndex = 18;
            this.btn_deleteCurrentUser.Text = "Eliminar Usuario";
            this.btn_deleteCurrentUser.UseVisualStyleBackColor = true;
            this.btn_deleteCurrentUser.Click += new System.EventHandler(this.btn_deleteCurrentUser_Click);
            // 
            // btn_deleteComputer
            // 
            this.btn_deleteComputer.Location = new System.Drawing.Point(191, 370);
            this.btn_deleteComputer.Name = "btn_deleteComputer";
            this.btn_deleteComputer.Size = new System.Drawing.Size(127, 23);
            this.btn_deleteComputer.TabIndex = 19;
            this.btn_deleteComputer.Text = "Eliminar Computadora";
            this.btn_deleteComputer.UseVisualStyleBackColor = true;
            this.btn_deleteComputer.Click += new System.EventHandler(this.btn_deleteComputer_Click);
            // 
            // btn_addComputer
            // 
            this.btn_addComputer.Location = new System.Drawing.Point(191, 341);
            this.btn_addComputer.Name = "btn_addComputer";
            this.btn_addComputer.Size = new System.Drawing.Size(127, 23);
            this.btn_addComputer.TabIndex = 20;
            this.btn_addComputer.Text = "Agregar Computadora";
            this.btn_addComputer.UseVisualStyleBackColor = true;
            this.btn_addComputer.Click += new System.EventHandler(this.btn_addComputer_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(682, 341);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(106, 23);
            this.btn_AddUser.TabIndex = 21;
            this.btn_AddUser.Text = "Agregar Usuario";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // Window_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btn_addComputer);
            this.Controls.Add(this.btn_deleteComputer);
            this.Controls.Add(this.btn_deleteCurrentUser);
            this.Controls.Add(this.listbox_sales);
            this.Controls.Add(this.lbl_weeklySales);
            this.Controls.Add(this.lbl_todaySales);
            this.Controls.Add(this.lbl_computerList);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lbl_busy);
            this.Controls.Add(this.btn_enable);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.lbl_elapsedTime);
            this.Controls.Add(this.lbl_LockedTime);
            this.Controls.Add(this.txt_elapsedTime);
            this.Controls.Add(this.txt_LockedTime);
            this.Controls.Add(this.list_computer);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_logout);
            this.Name = "Window_Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ListBox list_computer;
        private System.Windows.Forms.TextBox txt_LockedTime;
        private System.Windows.Forms.TextBox txt_elapsedTime;
        private System.Windows.Forms.Label lbl_LockedTime;
        private System.Windows.Forms.Label lbl_elapsedTime;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Button btn_enable;
        private System.Windows.Forms.Label lbl_busy;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Label lbl_computerList;
        private System.Windows.Forms.Label lbl_todaySales;
        private System.Windows.Forms.Label lbl_weeklySales;
        private System.Windows.Forms.ListBox listbox_sales;
        private System.Windows.Forms.Button btn_deleteCurrentUser;
        private System.Windows.Forms.Button btn_deleteComputer;
        private System.Windows.Forms.Button btn_addComputer;
        private System.Windows.Forms.Button btn_AddUser;
    }
}