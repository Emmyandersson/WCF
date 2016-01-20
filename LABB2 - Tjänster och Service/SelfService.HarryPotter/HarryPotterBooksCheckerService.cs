using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfService.HarryPotter
{
    class HarryPotterBooksCheckerService : IHarryPotterBooks
    {
        public string BookName(string name)
        {
            var books = new List<string>() {"Harry Potter and the Philosophers Stone", "Harry Potter and the Chamber of Secrets", "Harry Potter and the Prisoner of Azkaban", "Harry Potter and the Goblet of Fire", "Harry Potter and the Order of the Phoenix", "Harry Potter and the Half Blood Prince", "Harry Potter and the Deathly Hallows"};
            foreach (var book in books)
            {
                if (book.ToLower().Contains(name.ToLower()))
                {
                    return book;
                }
               
            }
            return "No book contains that name.";
        }
    }
}
