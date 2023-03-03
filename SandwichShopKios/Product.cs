using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichShopKios
{
    public class Product
    {
        public string name { get; set; }
        public Image image { get; set; }
        public int id { get; set; }
        public decimal price { get; set; }

        public Product() 
        { 
        }

        //Constructor used to initialise the product
        public Product(string name, Image image)
        {
            this.name = name;
            this.image = image;
        }
    }
}
