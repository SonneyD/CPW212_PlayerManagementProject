using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule.DatebaseUtility
{
    public static class PlayerDB
    {
        public static List<Player> LoadAllPlayers()
        {
            PlayerDBModel context = new PlayerDBModel();

            List<Player> pList = context.Players.ToList();

            return pList;
        }


        public static void AddPlayer(Player p)
        {
            PlayerDBModel context = new PlayerDBModel();

            try
            {
                // Add Player to DB
                context.Players.Add(p);

                // Save Changes.
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddItem( Item i )
        {
            PlayerDBModel con = new PlayerDBModel();

            try
            {
                con.Items.Add(i);
                con.SaveChanges();
            }
            catch // Not doing anything with exception atm
            {

            }
        }
        public static List<Item> GetAllItems()
        {
            PlayerDBModel con = new PlayerDBModel();

            List<Item> itemList = (from Item in con.Items
                                   where Item.ItemID > 0
                                    orderby Item.ItemID descending
                                    select Item).ToList();

            return itemList;
        }

        public static void UpdateItem(Item pItem)
        {
            if(checkItemIsValid(pItem))
            {
                var con = new PlayerDBModel();

                Item fromDB = con.Items.Find(pItem.ItemID);

                fromDB.ItemName = pItem.ItemName;
                fromDB.ItemDesc = pItem.ItemDesc;

                con.SaveChanges();
            }
        }
        public static void AddItemToInventory(Player pPlayer, Item pItem)
        {
            var con = new PlayerDBModel();

            try
            {
                con.Inventories.Add(new Inventory(pPlayer, pItem));
                con.SaveChanges();
            }
            catch(Exception ex)
            {

            }
        }
        public static void DeleteItemFromInventory(Player pPlayer, Item pItem)
        {
            var con = new PlayerDBModel();
            List<Inventory> invList = GetAllPlayerItems(pPlayer, pItem);

            if (invList.Count > 0)
            {
                con.Inventories.Remove(invList[0]);
                con.SaveChanges();
            }
        }
        public static List<Inventory> GetAllPlayerItems(Player pPlayer)
        {
            PlayerDBModel con = new PlayerDBModel();

            List<Inventory> itemList = (from Item in con.Inventories where(Item.PlayerID == pPlayer.PlayerID) select Item).ToList();

            return itemList;
        }
        public static string GetItemByID( int id )
        {
            PlayerDBModel con = new PlayerDBModel();

            return (from item in con.Items where item.ItemID == id select item).ToString();
        }
        public static List<Inventory> GetAllPlayerItems(Player pPlayer, Item pItem)
        {
            PlayerDBModel con = new PlayerDBModel();

            List<Inventory> itemList = 
                (from inv in con.Inventories
                 where ( inv.PlayerID == pPlayer.PlayerID && inv.ItemID == pItem.ItemID )
                                        orderby inv.ItemID descending select inv).ToList();

            return itemList;
        }
        public static bool checkItemIsValid(Item pItem)
        {
            if(pItem != null)
                if(!pItem.ItemName.Equals("") && pItem.ItemName.Length > 3)
                    if(!pItem.ItemDesc.Equals("") && pItem.ItemDesc.Length > 3)
                        return true;
            
            return false;
        }
    }
}
