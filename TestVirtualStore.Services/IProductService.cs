using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        void ReplacementProduct(int id, int quantity);
    }
}
