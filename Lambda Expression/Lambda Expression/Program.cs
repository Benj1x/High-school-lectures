using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(@"C:\Users\Bruger\Desktop\libraryData50.txt");
                StreamReader sr = new StreamReader(fs);
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    //string textExample = line.Substring(10);
                    string[] textElements = line.Split('"');
                    string title = textElements[1];
                    string[] txtEl = textElements[2].Split();
                    string ISBN = txtEl[1];
                    bool isLent = bool.Parse(txtEl[2]);
                    string author = textElements[3];
                    //int year = int.Parse(textElements[4].Trim());
                    string year = textElements[4].Trim();


                    library.Add(new Book(title, ISBN, isLent, author, year));
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong format in input file!");
            }
             catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("Bøgerne i biblioteket er sorteret i alfabetisk rækkefølge efter forfatter.");
            library = library.OrderBy(x => x.getAuthor()).ToList();
            //Int a bruges kun til at angive hvad nummer i rækkefølgen bogen har.
            int a = 1;
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Bog nr: " + a);
                Console.WriteLine(library[i].getTitle());
                Console.WriteLine("By " + library[i].getAuthor());
                Console.WriteLine(library[i].getISBN());
                Console.WriteLine("Is it lent out? " + library[i].getIsLent());
                Console.WriteLine("The book is from: " + library[i].getYear());
                Console.WriteLine();
                a++;

            }
            Console.ReadKey();

            int aa = 1;
            library.Find(x => x.getAuthor().Contains("J"));
            for (int i = 0; i < library.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Bog nr: " + aa);
                Console.WriteLine(library[i].getTitle());
                Console.WriteLine("By " + library[i].getAuthor());
                Console.WriteLine(library[i].getISBN());
                Console.WriteLine("Is it lent out? " + library[i].getIsLent());
                Console.WriteLine("The book is from: " + library[i].getYear());
                Console.WriteLine();
                aa++;

            }
            Console.ReadKey();
        }
    }
}
