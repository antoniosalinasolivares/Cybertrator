namespace Cybertrator
{
    partial class window_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.pic_usericon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usericon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(115, 212);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Iniciar Sesion";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(98, 175);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(132, 20);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(98, 149);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(132, 20);
            this.txtbox_user.TabIndex = 0;
            // 
            // pic_usericon
            // 
            this.pic_usericon.ErrorImage = global::Cybertrator.Properties.Resources.usericon;
            this.pic_usericon.Image = global::Cybertrator.Properties.Resources.usericon;
            this.pic_usericon.Location = new System.Drawing.Point(116, 28);
            this.pic_usericon.Name = "pic_usericon";
            this.pic_usericon.Size = new System.Drawing.Size(100, 100);
            this.pic_usericon.TabIndex = 3;
            this.pic_usericon.TabStop = false;
            // 
            // window_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 263);
            this.Controls.Add(this.pic_usericon);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.btn_login);
            this.Name = "window_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicia Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pic_usericon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.PictureBox pic_usericon;
    }
}

