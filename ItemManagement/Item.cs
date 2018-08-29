using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule
{
    public partial class Item
    {
        /******************************************************/
        // Member variables
        /*
        private string itemName;
        private string itemDesc;
        private long itemNum; // This is a number refering to the object's unquie ID
        */
        // private Properties prop; // This class contains generic object information. Physics, Graphics, Ect.

        /******************************************************/
        // Constructor
 
        public Item( string name, string desc, long itemNum )
        {
            this.ItemName = name;
            this.ItemDesc = desc;
        }


        /******************************************************/
        // Gettors
        public string getName() { return this.ItemName;  }
        public string getDesc() { return this.ItemDesc;  }

        /******************************************************/
        // Settors

        /******************************************************/
        // Utility

        /******************************************************/
        // Misc.
        public override string ToString()
        {
            return this.ItemName;
        }
        /******************************************************/
    }
}
