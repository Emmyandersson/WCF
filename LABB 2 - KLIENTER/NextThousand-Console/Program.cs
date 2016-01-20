using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextThousand_Console
{
   public class Program
    {
        static void Main(string[] args)
        {
            NextThousandClient client = new NextThousandClient();
            Console.WriteLine("Skriv ditt födelsedatum (YYYY/MM/DD): ");
            Console.WriteLine("Du fyller tusen dagar igen den: " + client.NextThousandDays(DateTime.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
