using System.Collections.Generic;
using PlayerDatabaseModule.Exceptions;


namespace PlayerDatabaseModule
{
    partial class Inventory
    {
        /******************************************************/
        // Member Variables
        private List<Item> itemList;
        private Player owner; // A reference to its owner

        /******************************************************/
        // Constructors
        public Inventory(Player pOwner)
        {
            this.itemList = new List<Item>();

            if (pOwner != null)
                this.owner = pOwner;
            else throw new InvalidObjectPointer("Inventory was initialized without a valid owner | Inventory-> Inventory(pOwner)");
        }
        public Inventory(Player pOwner, List<Item> list)
        {
            this.itemList = list;

            if (pOwner != null)
                this.owner = pOwner;
            else throw new InvalidObjectPointer("Inventory was initialized without a valid owner | Inventory-> Inventory(pOwner, list)");
        }


        /******************************************************/
        // Gettors
        public List<Item> getItemList() { return this.itemList; }
        public Player getPOwner() { return this.owner; }

        public List<Item> getItemByName( string name ) // Returns a list of all items that match the given ID
        {
            List<Item> list = new List<Item>();

            foreach( Item obj in this.itemList )
            {
                if (obj.getName().Equals(name))
                    list.Add(obj);
            }
            return list;
        }
        public Item getItemByID( long id )
        {
            foreach (Item obj in this.itemList)
            {
                if (obj.getNum() == id)
                    return obj;
            }
            return null;
        }

        /******************************************************/
        // Settors

        /******************************************************/
        // Misc
        public void addItem( Item obj )
        {
            if (obj != null)
                this.itemList.Add(obj);
        }
        //public void removeItem( )
    }
}
