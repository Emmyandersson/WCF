using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAge_Console
{
   public class Program
    {
        static void Main(string[] args)
        {
            var client = new AgeClient();
            Console.WriteLine("Skriv när du är född: YYYY/MM/DD");
            var birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Du är: "+ client.HowOldAmI(birthday.Date)+ " år gammal.");
            Console.ReadKey();
        }
    }
}
