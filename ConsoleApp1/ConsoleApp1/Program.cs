using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
                int sum = 0;
                for (int i = 1; i <= 40; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum = sum - i;
                        continue;
                    }
                    sum = sum + i;
                }
                
                Console.WriteLine(sum);
            Console.ReadKey();
        }
        
    }
}
