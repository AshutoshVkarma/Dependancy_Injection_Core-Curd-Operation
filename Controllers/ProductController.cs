using Dependancy_Injection_Core.Models;
using Dependancy_Injection_Core.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependancy_Injection_Core.Controllers
{
    public class ProductController : Controller
        
    {
        IProduct Product;
        public ProductController(ApplicationContext _context , IProduct _Product)
        {
            Product = _Product;
        }
        public IActionResult Index()
        {
            return View(Product.GetProducts());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Products prod)
        {
            Product.CreateProduct(prod);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(Product.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Update(Products prod)
        {
            Product.UpdateProduct(prod);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Product.DeleteProduct(id);
            return RedirectToAction("Index");
        }


    }
}
