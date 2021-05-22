using System.Collections.Generic;

namespace WebApplicationEjemplo.Models
{
    public class Products
    {
        public List<Product> ProductList { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}