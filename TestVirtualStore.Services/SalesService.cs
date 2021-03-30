using System.Collections.Generic;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Repository;

namespace TestVirtualStore.Services
{
    public class SalesService : ISalesService
    {
        private IRepository<Sales> _salesRepository;

        public SalesService(IRepository<Sales> salesRepository)
        {
            this._salesRepository = salesRepository;            
        }

        public IEnumerable<Sales> GetSales()
        {
            return _salesRepository.GetAll();
        }

        public Sales GetSale(int id)
        {
            return _salesRepository.Get(id);
        }

        public void InsertSale(Sales sales)
        {
            _salesRepository.Insert(sales);
        }
    }
}
