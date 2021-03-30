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
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetProduct()
        {
            return productService.GetProducts().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            return productService.GetProduct(id);
        }

        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            productService.InsertProduct(product);
            return CreatedAtAction("GetProduct",new { id = product.ID},product);
        }

        [HttpPut("{id}")]
        public IActionResult PutProduct(int id,Product product)
        {
            if (id != product.ID)
            {
                return BadRequest();
            }

            Product productEntity = productService.GetProduct(id);
            productEntity.Product_Name = product.Product_Name;
            productEntity.Product_Code = product.Product_Code;
            productEntity.Price = product.Price;
            productEntity.Quantity = product.Quantity;

            productService.UpdateProduct(productEntity);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var product = productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            productService.DeleteProduct(id);

            return product;
        }

    }
}
