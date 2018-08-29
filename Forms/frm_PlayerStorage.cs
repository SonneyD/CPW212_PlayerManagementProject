using System;
using System.Collections.Generic;
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
            if (cbox_ItemList.SelectedItem != null)
            {
                AddItemToInventory(player, (Item)cbox_ItemList.SelectedItem);

                lbox_pInventory.Items.Add(cbox_ItemList.SelectedItem.ToString());
            }
        }

        private void btn_displayItemInfo_Click(object sender, EventArgs e)
        {
            if( cbox_ItemList.SelectedItem != null )
            {
                var form = new frm_DisplayItemInfo((Item)cbox_ItemList.SelectedItem);
                DialogResult res = form.ShowDialog();
            }
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (lbox_pInventory.SelectedItem != null)
            {
                //DeleteFromInventory(player, GetItemByName(lbox_pInventory.SelectedItem.ToString()));

                DeleteItemFromPlayerInventory(player, GetItemByName(lbox_pInventory.SelectedItem.ToString()));

                populateItemList();
            }
        }

        private void onLoad()
        {
            txt_PlayerField.Text = player.Username;
            cbox_ItemList.Items.Clear();
            populateItemList();
            
        }
        private void populateItemList()
        {
            List<Item> list = GetAllItems();
            List<Inventory> inList = GetPlayerInventory(player);

            cbox_ItemList.Items.Clear();

            foreach( Item i in list )
            {
               cbox_ItemList.Items.Add(i);
            }

            lbox_pInventory.Items.Clear();

            foreach (Inventory i in inList)
            {
                lbox_pInventory.Items.Add(GetItemByID(i.ItemID));
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

        private void lbox_pInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_PlayerField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
