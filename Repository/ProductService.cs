using Dependancy_Injection_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependancy_Injection_Core.Repository
{
    public class ProductService : IProduct
    {
        private ApplicationContext context;
        public ProductService(ApplicationContext _context)
        {
            context = _context;
        }

        public Products CreateProduct(Products prod)
        {
            context.Products.Add(prod);
            context.SaveChanges();
            return prod;
        }

        public bool DeleteProduct(int id)
        {
            var item = context.Products.Where(e => e.Id == id).FirstOrDefault();
            context.Products.Remove(item);
            context.SaveChanges();
            return true;
        }

        public Products GetProductById(int id)
        {
            var item = context.Products.Where(e => e.Id == id).FirstOrDefault();
            return item;
        }

        public List<Products> GetProducts()
        {
            var item = context.Products.ToList();
            return item;
        }

        public Products UpdateProduct(Products prod)
        {
            context.Entry(prod).State = EntityState.Modified;
            context.SaveChanges();
            return prod;
        }

    }
}
