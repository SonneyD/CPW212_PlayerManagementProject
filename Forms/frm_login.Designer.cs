﻿namespace PlayerDatabaseModule
{
    partial class form_Login
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_RegisterPlayer = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(27, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // btn_RegisterPlayer
            // 
            this.btn_RegisterPlayer.Location = new System.Drawing.Point(159, 125);
            this.btn_RegisterPlayer.Name = "btn_RegisterPlayer";
            this.btn_RegisterPlayer.Size = new System.Drawing.Size(94, 34);
            this.btn_RegisterPlayer.TabIndex = 2;
            this.btn_RegisterPlayer.Text = "Register New User";
            this.btn_RegisterPlayer.UseVisualStyleBackColor = true;
            this.btn_RegisterPlayer.Click += new System.EventHandler(this.btn_RegisterPlayer_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(91, 27);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(136, 20);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(29, 77);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(91, 74);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(136, 20);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(32, 125);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(94, 34);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 181);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_RegisterPlayer);
            this.Controls.Add(this.lbl_username);
            this.Name = "form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_RegisterPlayer;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_login;
    }
}

