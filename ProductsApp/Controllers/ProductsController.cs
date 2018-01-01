using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product {  Id=1,Name="Hp",Categori="pcs",Price=1500000 },
            new Product {Id=2,Name="Pride",Categori="Cars",Price=25000000 },
              new Product { Id = 3, Name = "Yo-yo", Categori = "Toys", Price = 3.75M }

        };

        public IEnumerable<Product>GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
