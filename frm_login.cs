using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerDatabaseModule
{
    public partial class form_Login : Form
    {
        public form_Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /* Attempt Login
                -> Query PlayerDB
                    -> Find user by username
                        -> Check Password | return true or false    
            */

            /* if successful
                    -> Open UserInfo form
               if failed
                    -> Open Invalid Info MsgBox
             */



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
    }
}
