using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalsInventory.Logic.Models
{
    public class ChemicalModel
    {
        public int ChemicalId { get; set; }
        public string ChemicalName { get; set; }
        public string ChemicalQuantity { get; set; }
    }
}
