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
    public partial class frm_DisplayItemInfo : Form
    {
        private bool editFlag;
        private Item item;

        public frm_DisplayItemInfo(Item pItem)
        {
            InitializeComponent();
            populateFields(pItem);
            editFlag = false;
            item = pItem;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (!editFlag)
            {
                editFlag = true;
                toggleReadOnly();
                btn_Edit.Text = "Save Changes";
            }
            else
            {
                // Call Update on DB
                toggleReadOnly();
                editFlag = false;
                btn_Edit.Text = "Edit";

                item.ItemName = txt_Name.Text;
                item.ItemDesc = rtxt_Description.Text;
                UpdateItem(item);
            }
        }
        private void toggleReadOnly()
        {
            txt_Name.ReadOnly = !txt_Name.ReadOnly;
            rtxt_Description.ReadOnly = !rtxt_Description.ReadOnly;
        }
        private void populateFields(Item pItem)
        {
            if(pItem != null)
            {
                txt_Name.Text = pItem.ItemName;
                rtxt_Description.Text = pItem.ItemDesc;
            }
        }
    }
}
