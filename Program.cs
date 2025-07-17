using DesafioSecao8.Entities;
using DesafioSecao8.Enums;


namespace DesafioSecao8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clienteName = Console.ReadLine();
            Console.Write("Email: ");
            string clienteEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clienteBirthDate = DateTime.Parse(Console.ReadLine());

            Client newCliente = new Client(clienteName, clienteEmail, clienteBirthDate);
            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());



        }
    }
}
