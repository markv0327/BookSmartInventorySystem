using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSmartInventorySystem
{
    //data model class, properties that represent the attributes
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Location { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }

}
