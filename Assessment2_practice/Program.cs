namespace Assessment2_practice
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Read the values from user
            Console.WriteLine("Enter the species to Buy");
            string species = Console.ReadLine();
            Console.WriteLine("Enter the price per fish");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of fishes you need to buy");
            int numberOfFishes=int.Parse(Console.ReadLine());

            FishUtility fishUtility = new FishUtility();
            
            //call the AddFish Method 
            fishUtility.AddFish(species, price);

            //Calculate the total cost
            if (fishUtility.BuyFish())
            {
                double result = fishUtility.CalculatePrice(numberOfFishes);
                Console.WriteLine("Total cost is " + result);
            }
            else
            {
                Console.WriteLine($"{species} species not found");
            }

        }
    }
}
