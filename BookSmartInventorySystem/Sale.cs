using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmartInventorySystem
{
    //data model class, properties that represent the attributes
    public class Sale
    {
        public int SaleID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }

}
