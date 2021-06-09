using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalsInventory.Logic
{
    public class ItemModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string ItemUnit { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
    }
}
