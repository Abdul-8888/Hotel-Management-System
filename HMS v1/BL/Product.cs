using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_v1.BL
{
    public class Product
    {
        private int productId;
        private string name;
        private int unitPrice;
        private string type;

        public int ProductId { get => productId; set => productId = value; }
        public string Name { get => name; set => name = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string Type { get => type; set => type = value; }
    
        public Product(int productId, string name, int unitPrice, string type)
        {
            ProductId = productId;
            Name = name;
            UnitPrice = unitPrice;
            Type = type;
        }

        public Product(string name, int unitPrice, string type)
        {
            Name = name;
            UnitPrice = unitPrice;
            Type = type;
        }
    }
}
