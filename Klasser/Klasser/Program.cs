using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookExample = new Book("Wassup my nibba", "2", true, "3", 4);
            Console.WriteLine(bookExample.getTitle());
            Console.ReadKey();
        }
    }
}
