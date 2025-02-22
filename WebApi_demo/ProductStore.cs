﻿using WebApi_demo.Models;

namespace WebApi_demo
{
    public class ProductStore
    {
        private List<Product> products;
        public ProductStore()
        {
            products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Product_1"},
                new Product() { Id = 2, Name = "Product_2"},
                new Product() { Id = 3, Name = "Product_3"}
            };
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await Task.FromResult(products);
        public async Task<Product> GetProductByIdAsync(int id) => await Task.FromResult(products.First(products => products.Id == id));
        public async Task AddProductAsync(Product product)
        {
            products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<int> GetLastProductIdAsync() => await Task.FromResult(products.Count > 0 ? products.OrderBy(p => p.Id).Last().Id : 0);
    }
}
