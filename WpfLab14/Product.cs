using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab14
{
    public enum ProductCategory
    {
        Eat,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Foto { get; set; }
        public ProductCategory Category { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
