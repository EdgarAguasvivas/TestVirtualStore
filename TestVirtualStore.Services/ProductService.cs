using System;
using System.Collections.Generic;
using System.Text;
using TestVirtualStore.Repository;
using TestVirtualStore.DataAccess;

namespace TestVirtualStore.Services
{
    public class ProductService : IProductService
    {
        private IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProduct(int id)
        {
            return _productRepository.Get(id);
        }

        public void InsertProduct(Product product)
        {
            _productRepository.Insert(product);
        }
        public void UpdateProduct(Product product)
        {
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            _productRepository.Remove(product);
            _productRepository.SaveChanges();
        }

        public void ReplacementProduct(int id,int quantity)
        {
            Product product = GetProduct(id);
            product.Quantity = quantity;

            UpdateProduct(product);
        }     
    }
}
