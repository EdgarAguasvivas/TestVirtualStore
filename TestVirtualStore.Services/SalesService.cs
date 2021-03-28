using System.Collections.Generic;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Repository;

namespace TestVirtualStore.Services
{
    public class SalesService : ISalesService
    {
        private IRepository<Sales> salesRepository;

        public SalesService(IRepository<Sales> salesRepository)
        {
            this.salesRepository = salesRepository;            
        }

        public IEnumerable<Sales> GetSales()
        {
            return salesRepository.GetAll();
        }

        public Sales GetSale(int id)
        {
            return salesRepository.Get(id);
        }

        public void InsertSale(Sales sales)
        {
            salesRepository.Insert(sales);
        }
    }
}
