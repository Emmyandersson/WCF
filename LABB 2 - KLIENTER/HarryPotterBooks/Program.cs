using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            HarryPotterBooksClient client = new HarryPotterBooksClient();
            Console.WriteLine("Skriv ett ord som finns i Harry Potter böckernas titel");
            Console.WriteLine(client.BookName(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
