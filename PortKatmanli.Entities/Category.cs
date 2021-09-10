using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Entities
{
    public class Category
    {
        public int CategoryId => CategoryName == "Export" ? 1 : CategoryName == "Import" ? 2 : CategoryName == "Storage" ? 3 : 4;
        public string CategoryName { get; set; }
    }
}
