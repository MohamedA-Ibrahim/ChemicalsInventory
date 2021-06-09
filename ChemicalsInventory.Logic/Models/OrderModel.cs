using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalsInventory.Logic.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string OrderDescription { get; set; }
        public int ItemId { get; set; }
        public int OrderQuantity { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
