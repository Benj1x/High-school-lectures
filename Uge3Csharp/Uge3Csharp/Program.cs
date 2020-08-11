using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("VolksWagen", "50", "250", false, 2018);
            Console.WriteLine(Car1.getBrand(), Car1.getSpeed(), Car1.gettopSpeed(), Car1.getisUsed(), Car1.getYear());
            Console.WriteLine(Car1.getSpeed());
            Console.WriteLine(Car1.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the Car used? " + Car1.getisUsed());
            Console.WriteLine("What year is the car from? " + Car1.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car2 = new Car("Opel", "70", "255", true, 2017);
            Console.WriteLine(Car2.getBrand());
            Console.WriteLine(Car2.getSpeed());
            Console.WriteLine(Car2.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the Car used? " + Car2.getisUsed());
            Console.WriteLine("What year is the car from? " + Car2.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car3 = new Car("Ford", "75", "260", false, 2018);
            Console.WriteLine(Car3.getBrand());
            Console.WriteLine(Car3.getSpeed());
            Console.WriteLine(Car3.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the Car used " + Car3.getisUsed());
            Console.WriteLine("What year is the car from? " + Car3.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car4 = new Car("BMW", "100", "275", false, 2019);
            Console.WriteLine(Car4.getBrand());
            Console.WriteLine(Car4.getSpeed());
            Console.WriteLine(Car4.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car4.getisUsed());
            Console.WriteLine("What year is the car from? " + Car4.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car5 = new Car("Skoda", "45", "100", true, 2013);
            Console.WriteLine(Car5.getBrand());
            Console.WriteLine(Car5.getSpeed());
            Console.WriteLine(Car5.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car5.getisUsed());
            Console.WriteLine("What year is the car form? " + Car5.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car6 = new Car("Fiat", "55", "55", true, 2012);
            Console.WriteLine(Car6.getBrand());
            Console.WriteLine(Car6.getSpeed());
            Console.WriteLine(Car6.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car6.getisUsed());
            Console.WriteLine("What year is the car form? " + Car6.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car7 = new Car("Volvo", "60", "60", true, 2012);
            Console.WriteLine(Car7.getBrand());
            Console.WriteLine(Car7.getSpeed());
            Console.WriteLine(Car7.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car7.getisUsed());
            Console.WriteLine("What year is the car form? " + Car7.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car8 = new Car("Renault", "75", "80", true, 2015);
            Console.WriteLine(Car8.getBrand());
            Console.WriteLine(Car8.getSpeed());
            Console.WriteLine(Car8.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car8.getisUsed());
            Console.WriteLine("What year is the car form? " + Car8.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car9 = new Car("Tesla", "250", "300", false, 2019);
            Console.WriteLine(Car9.getBrand());
            Console.WriteLine(Car9.getSpeed());
            Console.WriteLine(Car9.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car9.getisUsed());
            Console.WriteLine("What year is the car form? " + Car9.getYear());
            Console.ReadKey();

            Console.WriteLine("\n");

            Car Car10 = new Car("Ferrai", "300", "450", false, 2017);
            Console.WriteLine(Car10.getBrand());
            Console.WriteLine(Car10.getSpeed());
            Console.WriteLine(Car10.gettopSpeed() + " Km/h");
            Console.WriteLine("Is the car used? " + Car10.getisUsed());
            Console.WriteLine("What year is the car form? " + Car10.getYear());
            Console.ReadKey();
        }
    }
}
