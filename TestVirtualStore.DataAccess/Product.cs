using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class Product : BaseEntity
    {
        public string Product_Code { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public ICollection<Sales> Sales { get; set; }
    }
}
