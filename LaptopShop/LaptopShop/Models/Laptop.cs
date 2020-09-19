using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaptopShop.Models
{
    public class Laptop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Core { get; set; }
        public string Generation { get; set; }
        public string company { get; set; }
        public int price { get; set; }

        internal static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}