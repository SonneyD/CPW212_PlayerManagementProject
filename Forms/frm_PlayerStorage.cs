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
    public partial class frm_PlayerStorage : Form
    {
        private Player player;
        public frm_PlayerStorage( Player pPlayer )
        {
            InitializeComponent();

            player = pPlayer;

            onLoad();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_displayItemInfo_Click(object sender, EventArgs e)
        {

        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {

        }

        private void onLoad()
        {
            txt_PlayerField.Text = player.Username;
            populateItemList();
            
        }
        private void populateItemList()
        {
            List<Item> list = GetAllItems();

            foreach( Item i in list )
            {
                cbox_ItemList.Items.Add(i);
            }
        }

        private void cbox_ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CreateItem_Click(object sender, EventArgs e)
        {
            var cItem = new frm_AddItem();

            DialogResult res = cItem.ShowDialog();
            onLoad();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
