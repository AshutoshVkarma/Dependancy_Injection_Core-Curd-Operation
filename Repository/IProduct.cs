using Dependancy_Injection_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependancy_Injection_Core.Repository
{
    public interface IProduct
    {
        List<Products>GetProducts();
        Products GetProductById(int id);
        Products CreateProduct(Products prod);
        Products UpdateProduct(Products prod);
        bool DeleteProduct(int id);
        
    }
}
