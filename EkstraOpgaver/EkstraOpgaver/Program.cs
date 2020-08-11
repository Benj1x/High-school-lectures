using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraOpgaver
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> talTilTre = new List<int>();
            List<int> talTilSyv = new List<int>();
            Console.WriteLine("Opgave 1");
            Console.ReadKey();
            //For loop der er brugt til inspiration er her: https://www.includehelp.com/dot-net/print-even-and-odd-numbers-from-1-to-30-in-c-sharp.aspx
            for (int n = 1; n < (100 + 1); n++) //% (Modulus)
            {
                if (!(n % 3 != 0))
                {
                    talTilTre.Add(n);
                }
                if (!(n % 7 != 0))
                {
                    talTilSyv.Add(n);
                }
            }
            
            Console.ReadKey();
            Console.WriteLine("Tal der går op i tre");
            Console.ReadKey();
            foreach (int i in talTilTre)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine("Tal der går op i syv");
            foreach (int i in talTilSyv)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            //Opgave 2
            Random randNum = new Random();
            randNum.Next(1, 7);
//________________________________________________________________________

            Car car1 = new Car("Ford", "Mustang", "290hk", 15, 709010, 2019);


            Car car2 = new Car("Toyota", "Aygo x-play", "72hk", 25, 105990, 2019);
            
            Car car3 = new Car("Mitsubishi", "Outlander Phev", "150hk", 20, 329995, 2020);
         
            Car car4 = new Car("Land Rover", "Defender 110", "122hk", 10, 599500, 1992);
           
            Car car5 = new Car("Audi", "R8 Spyder", "570hk", 12, 3559055, 2015);

            //Her laves en liste med objekter i klassen. Lister er dejlige, husk lister til alle klasser du laver
            List<Car> carColl = new List<Car>();
            carColl.Add(car1); carColl.Add(car2); carColl.Add(car3); carColl.Add(car4); carColl.Add(car5);

            Console.WriteLine("Opgave 5");
            Console.WriteLine("Skriv dit søgeord ind for at finde din ønskede bil :)");
            

            bool isValidInput = false;
            while (!isValidInput)
            {
                string keyWord = Console.ReadLine();
                int value;
                if (int.TryParse(keyWord, out value))
                {
                    isValidInput = false;
                    Console.WriteLine("Søge ord findes ikke! Prøv eventuelt og fjerne alle tal fra søgeordet");

                }
            }
           /* Console.ReadKey();
            string search = Console.ReadLine();

            //Console.WriteLine("{0} Equals to {1}? : {2}", search, carColl, search.Equals(carColl, StringComparison.OrdinalIgnoreCase));



            Console.ReadLine();
            bool isValidInput = false;

            while (!isValidInput)
            {
                string svar = Console.ReadLine();
                string s = svar.ToLower();

                if (s == "dragen")
                {
                    isValidInput = true;
                }
                else if (s == "trollen")
                {
                    isValidInput = true;
                }
                else
                {
                    isValidInput = false;
                    Console.WriteLine("Det forstod jeg ikke, prøv igen :)");
                }
            }
            */

            Console.WriteLine("Opgave 7");
            Console.ReadKey();
            Console.WriteLine("Sorterert i alfabetisk rækkefølge (A-Z)");
            carColl=carColl.OrderBy(x => x.getBrand()).ToList();
            for (int i = 0; i < carColl.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(carColl[i].getBrand());
                Console.WriteLine(carColl[i].getModel());
                Console.WriteLine(carColl[i].getHorses());
                Console.WriteLine("Fra år " + carColl[i].getYear());
                Console.WriteLine(carColl[i].getPrice() + " Kroner");
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine("Sorteret fra Z-A");
            carColl = carColl.OrderByDescending(x => x.getBrand()).ToList();
            for (int i = 0; i < carColl.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(carColl[i].getBrand());
                Console.WriteLine(carColl[i].getModel());
                Console.WriteLine(carColl[i].getHorses());
                Console.WriteLine("Fra år " + carColl[i].getYear());
                Console.WriteLine(carColl[i].getPrice() + " Kroner");
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine("Sorteret efter årgang (Nyeste først - Ældste til sidst)");
            carColl = carColl.OrderByDescending(x => x.getYear()).ToList();
            for (int i = 0; i < carColl.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Fra år " + carColl[i].getYear());
                Console.WriteLine(carColl[i].getBrand());
                Console.WriteLine(carColl[i].getModel());
                Console.WriteLine(carColl[i].getHorses());
                Console.WriteLine(carColl[i].getPrice() + " Kroner");
                Console.WriteLine();
            }
            Console.ReadKey();
            //Opgave 8
            Console.WriteLine("Welcome");
            string input = Console.ReadLine();
            int useIn = int.Parse(input);

            /* switch ()
            {
                case 1:
                    Random randNum = new Random();
                    int num = randNum.Next(1, 7);
                    Console.WriteLine(num);
                    break;
                case 2:
                    carColl = carColl.OrderBy(x => x.getBrand);
                    break;
                default:
                    carColl = carColl.OrderBy(x => x.getBrand);
                    break;

            }
            */
            Console.WriteLine("Færdig :)");
            Console.ReadKey();
            
        }
    }
    
}

