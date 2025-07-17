using DesafioSecao8.Entities;
using DesafioSecao8.Enums;
using System.Globalization;


namespace DesafioSecao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clienteName = Console.ReadLine();
            Console.Write("Email: ");
            string clienteEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clienteBirthDate = DateTime.Parse(Console.ReadLine());

            Client newCliente = new Client(clienteName, clienteEmail, clienteBirthDate);
            order.Client = newCliente;
            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            order.OrderStatus = status;
            Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfItems; i++)
            {
                //getting info to make the product
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice); // creating product

                Console.Write("Quantity: "); // getting quantity to add to ordemitem
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(product, productQuantity);

                order.AddItem(orderItem);
            }


            Console.WriteLine(order.ToString());


        }
    }
}
