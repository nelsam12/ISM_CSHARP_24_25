using Cours.Models;

namespace Cours
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(1, "XXXX", "773461882", "Adresse XXXX");
            Console.WriteLine(client);
        }
    }

}
