using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsDictionary = new Dictionary<string, Student>()
            {
                { "Ivan Petrenko", new Student ( "Ivan", "Petrenko", "1", "43", "IF" ) },
            };

            Queue<Book> books = new Queue<Book>();

            books.Enqueue(new Book { Name = "1" });
            books.Enqueue(new Book { Name = "2" });
            books.Enqueue(new Book { Name = "3" });

            foreach (Book b in books)
            {
                Console.WriteLine($"Student took book {b.Name}");
            }

            Book book = books.Dequeue();
            Console.WriteLine($"Student return book {book.Name}");

            foreach (Book b in books)
            {
                Console.WriteLine($"Student return book {b.Name}");
            }
        }
    }
}
