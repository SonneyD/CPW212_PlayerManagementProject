﻿#define DEBUG

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static PlayerDatabaseModule.Security.Cryptography;

namespace PlayerDatabaseModule
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();

#if (DEBUG)
            txt_Username.Text = "admin";
            txt_Password.Text  = "Admin!";

            //TestFN();
#endif

            this.AcceptButton = btn_login;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;



            PlayerDBModel con = new PlayerDBModel();

            List<Player> pPlayer = (from Player in con.Players
                                    where Player.Username == username && Player.Password == password
                                    select Player).ToList();

            if (pPlayer.Count == 1)
            {
                var playerStr = new frm_PlayerStorage(pPlayer[0]);

                DialogResult res = playerStr.ShowDialog();
            }
            else
                MessageBox.Show("Your username or password is incorrect.", "Failed Login");

            // if failed, display a message box prompting user retry login
        }

        private void btn_RegisterPlayer_Click(object sender, EventArgs e)
        {
            // Open Registration Page
            var playerReg = new frm_UserRegistration();

            DialogResult res = playerReg.ShowDialog();

            if (res == DialogResult.OK)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
