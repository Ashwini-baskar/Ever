using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlipEver
{
    public class FlipEver
    {
        public string Product_categories { get; set; }
        public string Product_Name { get; set; }
        public string Product_Id { get; set; }
        public string price { get; set; }
        public string Quantity { get; set; }
        public string BillAmount { get; set; }
        
    }
    public class FlipEverCollection : List<FlipEver>
    {
        public void Add(FlipEver st)
        {
            base.Add(st);
        }
    }
}