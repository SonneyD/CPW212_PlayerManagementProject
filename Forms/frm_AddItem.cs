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
    public partial class frm_AddItem : Form
    {
        public frm_AddItem()
        {
            InitializeComponent();
        }

        private void btn_CreateItem_Click(object sender, EventArgs e)
        {
            if(!txt_ItemName.Text.Equals("") && !txt_ItemDesc.Text.Equals(""))
            {
                Item i = new Item(txt_ItemName.Text, txt_ItemDesc.Text, 0);
                try
                {
                    AddItem(i);
                    MessageBox.Show("An Item has been added to the database");
                    this.Close();
                }
                catch
                {

                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
