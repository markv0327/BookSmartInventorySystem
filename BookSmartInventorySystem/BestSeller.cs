using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmartInventorySystem
{
    //data model class, properties that represent the attributes
    public class Bestseller
    {
        public int BestsellerID { get; set; }
        public int BookID { get; set; }
        public int Rank { get; set; }
        public int SaleVolume { get; set; }
    }

}
