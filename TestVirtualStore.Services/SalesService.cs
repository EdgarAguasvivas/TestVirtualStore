using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public class SalesService
    {
        private IRepository<Sales> salesProfileRepository;

        public UserService(IRepository<Sales> salesProfileRepository)
        {
            this.salesProfileRepository = salesProfileRepository;            
        }

        public IEnumerable<Sales> GetSales()
        {
            return salesProfileRepository.GetAll();
        }

        public Sales GetSales(int id)
        {
            return salesProfileRepository.Get(id);
        }

        public void InsertSales(Sales sales)
        {
            salesProfileRepository.Insert(sales);
        }
    }
}
