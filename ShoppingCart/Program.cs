using System.Security.Cryptography.X509Certificates;

namespace ShoppingCart
{
    public class Program
    {
        public static List<BabyDress> DressCart { set; get; } = new List<BabyDress>();
        public static void Main(string[] args)
        {
            
            BabyDressUtility babyDressUtility = new BabyDressUtility();
            bool check = false;
            while (!check)
            {
                Console.WriteLine("1.Add dress to cart\n2.Remove dress from cart\n3.Exit\n");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            //Read details from the user
                            Console.WriteLine("Enter the dress size");
                            int size = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the dress color");
                            string color = Console.ReadLine();
                            Console.WriteLine("Enter the dress brand");
                            string brand = Console.ReadLine();
                            Console.WriteLine("Enter the dress price");
                            double price = double.Parse(Console.ReadLine());
                            BabyDress dress=new BabyDress(size,color,brand,price);

                            //call the AddDressToCart method
                            babyDressUtility.AddDressToCart(dress);
                            break;
                        }
                    case 2:
                        {   
                            //Read the name from the user
                            Console.WriteLine("Enter the dress brand to remove the dress from cart");
                            string brand1 = Console.ReadLine();

                            //Call RemoveDressUtility Method
                            bool result = babyDressUtility.RemoveDressFromCart(brand1);
                            if (result)
                            {
                                Console.WriteLine("Successfully removed from the cart");
                            }
                            else
                            {
                                Console.WriteLine("Brand not found");
                            }
                            break;
                        }
                    case 3:
                        {
                            check = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Choice. Please enter a valid choice");
                        break;
                }
            }
        }
        
            
       
    }

}

    

