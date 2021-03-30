using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Services;

namespace MardomTestVirtualStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _salesService;
        private readonly ISaleDetailService _saleDetailService;

        public SalesController(ISalesService salesService, ISaleDetailService saleDetailService)
        {
            this._salesService = salesService;
            this._saleDetailService = saleDetailService;
        }

        [HttpGet]
        public List<Sales> GetProduct()
        {
            return _salesService.GetSales().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Sales> GetProduct(int id)
        {
            return _salesService.GetSale(id);
        }

        [HttpPost]
        public ActionResult<Sales> PostProduct(Sales sales,SaleDetail saleDetail)
        {
            _salesService.InsertSale(sales);
            _saleDetailService.InsertSaleDetail(saleDetail);
            return CreatedAtAction("GetSale", new { id = sales.ID }, sales);
        }
    }
}
