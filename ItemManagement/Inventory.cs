using System.Collections.Generic;
using PlayerDatabaseModule.Exceptions;


namespace PlayerDatabaseModule
{
    partial class Inventory // The way its being used, it should really be called InventoryItem
    {
        /******************************************************/
        // Member Variables
        private Player owner; // A reference to its owner
        private Item pItem;

        /******************************************************/
        // Constructors
        public Inventory()
        { }
        public Inventory(Player pOwner)
        {
            if (pOwner != null)
                this.owner = pOwner;
            else throw new InvalidObjectPointer("Inventory was initialized without a valid owner | Inventory-> Inventory(pOwner)");
        }
        public Inventory(Player owner, Item item)
        {
            this.ItemID = item.ItemID;
            this.PlayerID = owner.PlayerID;

            this.owner = owner;
            this.pItem = item;
        }


        /******************************************************/
        // Gettors
        public Player getPOwner() { return this.owner; }
        public Item getpItem() { return this.pItem; }


        /******************************************************/
        // Settors

        /******************************************************/
        // Misc
        //public void removeItem( )

        public override string ToString()
        {
            if (pItem == null)
                return this.ItemID.ToString();
            else
                return this.pItem.ToString();
        }
    }
}
