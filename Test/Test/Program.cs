using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            double b = 5.5;
            string c = "Har du lige set B2's kusine?";
            bool d = true;

            if (d == true)
            {
                Console.WriteLine(c);
            }

            while (a < b)
            {
                a++;
                Console.WriteLine("");
                Console.WriteLine("Hello");
                Console.WriteLine("Benj1");
                Console.ReadKey();
                //ReadKey holder consolen åben indtil den modtager input, da consolen ellers lukker, hvis den ikke er der
            }

        }
    }
}
