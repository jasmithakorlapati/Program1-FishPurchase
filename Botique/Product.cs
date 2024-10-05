using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botique
{
    public class Product
    {
        public string Name {  get; set; }
        public int Stock {  get; set; }
        public Product(string name, int stock)
        {
            this.Name = name;
            this.Stock = stock;
        }

    }
    public class DeliverySystem
    {
        public bool placeOrder(Product product)
        {

            if (product.Stock > 0)
                return true;
            else
            {
                throw new ProductOutOfStockException();
            }
            return false;
        }

    }
}
            

