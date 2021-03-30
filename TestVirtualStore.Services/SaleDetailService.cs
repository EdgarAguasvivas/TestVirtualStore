using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Repository;

namespace TestVirtualStore.Services
{
    public class SaleDetailService
    {
        private IRepository<SaleDetail> _saleDetailRepository;

        public SaleDetailService(IRepository<SaleDetail> saleDetailRepository)
        {
            this._saleDetailRepository = saleDetailRepository;
        }

        public IEnumerable<SaleDetail> GetSaleDetails()
        {
            return _saleDetailRepository.GetAll();
        }

        public SaleDetail GetSale(int id)
        {
            return _saleDetailRepository.Get(id);
        }

        public void InsertSale(SaleDetail saleDetail)
        {
            _saleDetailRepository.Insert(saleDetail);
        }
    }
}
