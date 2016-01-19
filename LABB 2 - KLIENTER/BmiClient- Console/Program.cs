using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiClient__Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new BmiClient();
            Console.WriteLine("Skriv din längd jämnt i meter");
            var height = Console.ReadLine();
            Console.WriteLine("Skriv din vikt jämnt i kilo");
            var weight = Console.ReadLine();
            if (weight != null)
                if (height != null)
                    Console.WriteLine("Ditt bmi är: "+ client.Calculate(double.Parse(height),double.Parse(weight)));
            Console.ReadKey();
        }
    }
}
