using System;
using System.Collections.Generic;
using System.Text;

namespace TestVirtualStore.DataAccess
{
    public class Sales : BaseEntity
    {      
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }

        public int UserFK { get; set; }
        public User User { get; set; }

        public int ProductFK { get; set; }
        public Product Product { get; set; }
    }
}
