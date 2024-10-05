using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class BabyDress
    { 
        public int Size {  get; set; }
        public string Color {  get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public BabyDress(int size,string color, string brand, double price)
        {
            this.Size = size;
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
        }

    }
    public class BabyDressUtility
    {

        //Add dress to the Cart
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressCart.Add(dress);
            Console.WriteLine(dress.Color);
            Console.WriteLine("Successfully added to the dress cart");
        }
        //Remove the Dress from if brand is present
        public bool RemoveDressFromCart(string brand)
        {
            foreach(var dress in Program.DressCart)
            {
                if( dress.Brand==brand)
                {
                    Program.DressCart.Remove(dress);
                    return true;
                }
            }
            return false;
        }
    }
}
