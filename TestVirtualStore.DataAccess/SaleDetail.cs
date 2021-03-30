using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class SaleDetail : BaseEntity
    {
        public int Quantity { get; set; }

        public int ID_Sale { get; set; }
        public Sales Sales { get; set; }

        public int ID_Product { get; set; }
        public Product Product { get; set; }
    }
}
