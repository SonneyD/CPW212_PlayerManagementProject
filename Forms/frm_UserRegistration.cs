using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PlayerDatabaseModule.DatebaseUtility.PlayerDB;

namespace PlayerDatabaseModule
{
    public partial class frm_UserRegistration : Form
    {
        public frm_UserRegistration()
        {
            InitializeComponent();

            rtxt_Instructions.Text = "Please enter a username that is > 3 and < 16\n" + 
                "Please enter a password that has at least 1 Capital letter and 1 Symbol (!@#$%^&*)";
        }

        
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string email = txt_Email.Text;

            try
            {
                Player pPlayer = new Player(username, password, email);
                AddPlayer(pPlayer);
                this.Close();
                MessageBox.Show("User has been registered, Try logging in.");
            }
            catch(ArgumentException)
            {

            }

            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /***********************************************************************************/
        // The I forgot how to removes theses section XD

        private void rtxt_Instructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

    }
}
