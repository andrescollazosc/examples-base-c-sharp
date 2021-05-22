using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var lists = new Products {
                ProductList = GetProducts()
            };
            return View(lists);
        }

        public RedirectResult Redirect(string ProductList) {
            return Redirect("https://www.google.com/");
        }

        private List<Product> GetProducts() {
            return new List<Product> { 
                new Product { Id = 0, Title = "Arroz" },
                new Product { Id = 1, Title = "Azucar" },
            };
        }


    }
}