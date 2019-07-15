using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsDictionary = new Dictionary<string, Student>()
            {
                { "Ivan Petrenko", new Student ( "Ivan", "Petrenko", "1", "43", "IF" ) },
            };

            Stack<Task> tasks = new Stack<Task>();

            tasks.Push(new Task { Name = "1" });
            tasks.Push(new Task { Name = "2" });
            tasks.Push(new Task { Name = "3" });

            foreach (Task t in tasks)
            {
                Console.WriteLine($"Student get task {t.Name}");
            }

            Task task = tasks.Pop();
            Console.WriteLine($"Student done task {task.Name}");

            foreach (Task t in tasks)
            {
                Console.WriteLine($"Student done task {t.Name}");
            }
        }
    }
}
