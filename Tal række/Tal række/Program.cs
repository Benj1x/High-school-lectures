using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal_række
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int change = 1;
            int newNumber = 1;
            List<int> row = new List<int>();
            row.Add(newNumber);
            while (n < 9)
            {
                newNumber = newNumber + change;
                row.Add(newNumber);
                change = change + 1;
                n = n + 1;
            }

            foreach (int i in row)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
