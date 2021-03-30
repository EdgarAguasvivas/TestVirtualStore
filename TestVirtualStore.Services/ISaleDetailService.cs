using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public interface ISaleDetailService
    {
        IEnumerable<SaleDetail> GetSales();
        SaleDetail GetSaleDetail(int id);
        void InsertSaleDetail(SaleDetail saleDetail);
    }
}
