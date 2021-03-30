using System.Collections.Generic;
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
