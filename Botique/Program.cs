namespace Botique
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the product name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of stocks");
            int stock = int.Parse(Console.ReadLine());

            DeliverySystem deliverySystem = new DeliverySystem();
            Product product = new Product(name, stock);

            //check the 
            try
            {
                bool result = deliverySystem.placeOrder(product);
                if (result)
                    Console.WriteLine("Order placed Succesfully");
            }
            catch (ProductOutOfStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you!!!!");
            }

        }
    }
}

