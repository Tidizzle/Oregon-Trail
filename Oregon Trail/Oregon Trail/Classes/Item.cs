using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trail.Classes
{
    public class Item
    {
        private string itemName;
        private double itemPrice;
        private string itemDesc;
        private string itemRecc;
        private int itemAmm;

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }
        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }

            set
            {
                itemPrice = value;
            }
        }
        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }

            set
            {
                itemDesc = value;
            }
        }
        public string ItemRecc
        {
            get
            {
                return itemRecc;
            }

            set
            {
                itemRecc = value;
            }
        }
        public int ItemAmm
        {
            get
            {
                return itemAmm;
            }

            set
            {
                itemAmm = value;
            }
        }
    }
}
