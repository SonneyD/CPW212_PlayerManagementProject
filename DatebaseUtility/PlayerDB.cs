using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule.DatebaseUtility
{
    public static class PlayerDB
    {
        /**************************************************************************************/
        // Create
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddItem(Item i)
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

        public static void AddItemToInventory(Player pPlayer, Item pItem)
        {
            var con = new PlayerDBModel();

            try
            {
                con.Inventories.Add(new Inventory(pPlayer, pItem));
                con.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
        /*************************************************************************************/

        /**************************************************************************************/
        // Read

        /**************************************************************/
        // Player

        public static List<Player> LoadAllPlayers()
        {
            PlayerDBModel context = new PlayerDBModel();

            List<Player> pList = context.Players.ToList();

            return pList;
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

        /**************************************************************/
        // Item

        public static Item GetItemByName(string n)
        {
            PlayerDBModel con = new PlayerDBModel();

            List<Item> itemList = (from Item in con.Items
                                   where Item.ItemName == n
                                   orderby Item.ItemID descending
                                   select Item).ToList();

            return itemList.First();
        }
        /**************************************************************/
        // Inventory

        public static List<Inventory> GetItemFromPlayerInventory(Player p, Item i)
        {
            using (PlayerDBModel con = new PlayerDBModel())
            {
                if (p != null && i != null)
                    return con.Inventories.Where(x => x.PlayerID == p.PlayerID).ToList().Where(y => y.ItemID == i.ItemID).ToList();
            }
            return null;
        }

        public static List<Inventory> GetPlayerInventory(Player pPlayer)
        {
            PlayerDBModel con = new PlayerDBModel();

            return (from Item in con.Inventories where (Item.PlayerID == pPlayer.PlayerID) select Item).ToList();
        }

        public static Inventory GetItemFromInventory(Player pPlayer, Item pItem)
        {
            List<Inventory> inv = GetPlayerInventory(pPlayer);

            foreach (Inventory i in inv)
            {
                if (i.PlayerID == pPlayer.PlayerID && i.ItemID == pItem.ItemID)
                    return i;
            }

            return null; // Returns nothing if nothing is found.
        }

        public static Item GetItemByID(int id)
        {
            PlayerDBModel con = new PlayerDBModel();
            Item temp = (from item in con.Items where item.ItemID == id select item).ToList()[0];
            return temp;
        }

        /*************************************************************************************/

        /**************************************************************************************/
        // Update
        public static void UpdateItem(Item pItem)
        {
            if (checkItemIsValid(pItem))
            {
                var con = new PlayerDBModel();

                Item fromDB = con.Items.Find(pItem.ItemID);

                fromDB.ItemName = pItem.ItemName;
                fromDB.ItemDesc = pItem.ItemDesc;

                con.SaveChanges();
            }
        }

        /*************************************************************************************/

        /**************************************************************************************/
        // Delete
        public static void DeleteItemFromPlayerInventory(Player p, Item i)
        {
            if (p != null && i != null)
            {
                using (PlayerDBModel con = new PlayerDBModel())
                {
                    var iList = GetItemFromPlayerInventory(p, i);

                    if (iList.Count > 0)
                    {
                        var temp = iList.First();

                        con.Inventories.Add(temp);
                        con.Entry<Inventory>(temp).State = System.Data.Entity.EntityState.Deleted;
                        con.SaveChanges();
                    }
                }
            }
        }
        /*************************************************************************************/


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
