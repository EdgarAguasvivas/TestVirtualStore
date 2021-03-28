using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.Repository;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return productRepository.Get(id);
        }

        public void InsertProduct(Product product)
        {
            productRepository.Insert(product);
        }
        public void UpdateProduct(Product product)
        {
            productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            productRepository.Remove(product);
            productRepository.SaveChanges();
        }

        public void ReplacementProduct(int id,int quantity)
        {
            Product product = GetProduct(id);
            product.Quantity = quantity;

            UpdateProduct(product);
        }     
    }
}
