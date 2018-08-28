namespace PlayerDatabaseModule
{
    partial class frm_UserRegistration
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.rtxt_Instructions = new System.Windows.Forms.RichTextBox();
            this.txt_PasswordAgain = new System.Windows.Forms.TextBox();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(38, 83);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(38, 145);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(128, 76);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(172, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(128, 138);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(172, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(39, 214);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(117, 30);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // rtxt_Instructions
            // 
            this.rtxt_Instructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_Instructions.Location = new System.Drawing.Point(12, 12);
            this.rtxt_Instructions.Name = "rtxt_Instructions";
            this.rtxt_Instructions.ReadOnly = true;
            this.rtxt_Instructions.Size = new System.Drawing.Size(328, 45);
            this.rtxt_Instructions.TabIndex = 6;
            this.rtxt_Instructions.Text = "";
            this.rtxt_Instructions.TextChanged += new System.EventHandler(this.rtxt_Instructions_TextChanged);
            // 
            // txt_PasswordAgain
            // 
            this.txt_PasswordAgain.Location = new System.Drawing.Point(128, 174);
            this.txt_PasswordAgain.Name = "txt_PasswordAgain";
            this.txt_PasswordAgain.Size = new System.Drawing.Size(172, 20);
            this.txt_PasswordAgain.TabIndex = 3;
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Location = new System.Drawing.Point(38, 181);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(86, 13);
            this.lbl_password2.TabIndex = 8;
            this.lbl_password2.Text = "Password Again:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(183, 215);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 29);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(128, 109);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(172, 20);
            this.txt_Email.TabIndex = 1;
            // 
            // frm_UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.txt_PasswordAgain);
            this.Controls.Add(this.rtxt_Instructions);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "frm_UserRegistration";
            this.Text = "User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.RichTextBox rtxt_Instructions;
        private System.Windows.Forms.TextBox txt_PasswordAgain;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
    }
}