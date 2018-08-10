using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDatabaseModule
{
    public class Item
    {
        /******************************************************/
        // Member variables
        private string itemName;
        private string itemDesc;
        private long itemNum; // This is a number refering to the object's unquie ID

        // private Properties prop; // This class contains generic object information. Physics, Graphics, Ect.

        /******************************************************/
        // Constructor
        public Item( string name, string desc, long itemNum )
        {
            this.itemName = name;
            this.itemDesc = desc;
            this.itemNum = itemNum;
        }


        /******************************************************/
        // Gettors
        public string getName() { return this.itemName;  }
        public string getDesc() { return this.itemDesc;  }
        public long getNum() { return this.itemNum; }

        /******************************************************/
        // Settors

        /******************************************************/
        // Utility

        /******************************************************/
        // Misc.

        /******************************************************/
    }
}
