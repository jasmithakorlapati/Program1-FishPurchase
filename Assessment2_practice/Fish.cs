using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_practice
{
    public class Fish
    {
        public string Species { set; get; }
        public double PricePerFish {  set; get; }

    }
    public class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            this.Species = species;
            this.PricePerFish = pricePerFish;
        }
        public bool BuyFish()
        {
            if(Species.Equals("Clownfish")|| Species.Equals("Goldfish"))
            {
                return true;
            }
            return false;
        }
        public double CalculatePrice(int numberOfFishes)
        {
            if(Species.Equals("Clownfish"))
            {
                return (numberOfFishes *PricePerFish) + 100;
            }
            
                return (numberOfFishes*PricePerFish) + 150;
        }

    }
}
