using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public interface ISalesService
    {
        IEnumerable<Sales> GetSales();
        Sales GetSale(int id);
        void InsertSale(Sales sale);
    }
}
