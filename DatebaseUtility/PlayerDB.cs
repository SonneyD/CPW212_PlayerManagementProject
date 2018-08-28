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
                // Create a player inventory
                Inventory pInv = new Inventory(p);
                pInv.PlayerID = p.PlayerID;
                context.Inventories.Add(pInv);

                // Add Player to DB
                context.Players.Add(p);

                // Save Changes.
                context.SaveChanges();
            }
            catch(ArgumentException)
            {
                
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
    }
}
