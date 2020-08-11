using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2D2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            double b = 5.5;
            string text = "Hey bab";
            List<int> coll = new List<int>(); //laver en ny tom liste
            coll.Add(2); coll.Add(4); //Tilføjere til vores liste der hedder "coll"

            if (a < b){
                string userInput = Console.ReadLine();
                Console.WriteLine(userInput);
                Console.ReadKey();
             }

            while (a < b){
                b--;
            }

            for (int i = 0; i < a; i++){
                Console.WriteLine(coll[i]);
            }
            Console.ReadKey();

            bool isExiting = false;

            while (!isExiting)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("Please, enter menu item number between 0-1, to select option");
                Console.WriteLine("0. Exit program");
                Console.WriteLine("1. Randomly generate a number");

                string uInput = Console.ReadLine();
                int input = int.Parse(uInput);

                switch (input)
                {
                    case 1:
                        Random RandomNumber = new Random();
                        int result = RandomNumber.Next(0, 100);
                        Console.WriteLine("");
                        Console.WriteLine(result);
                        Console.WriteLine("");
                        break;

                    case 0:
                        isExiting = true;
                        Console.WriteLine("Exiting program");
                        Console.WriteLine("");
                        Console.WriteLine("Press any button to confirm");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
