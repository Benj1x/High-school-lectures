using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWeek48
{
    class Program
    {
        static void Main(string[] args)
        {
            //I denne opgave er der tilføjet bøger så der var i alt 10 bøger
            int aaaa = 1;
            List<Book> library = new List<Book>();
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(@"C:\Users\Bruger\Desktop\libraryData.txt");
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

            //Følgende kode viser alle bøger i alfabetisk rækkefølge.

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
            /**/
            //For at få int c ud af try/catch metoden, erklæres int c uden for  metoden
            int c = 0;
            
            Console.WriteLine("Hvilken bog vil du låne? (Angiv med hvad nummer den har i rækkefølgen)");
            //start: er et label
            start:

            try
            {
                string res = Console.ReadLine();
                c = int.Parse(res);
                c = c - 1;
                Console.WriteLine("Vil du låne bogen: " + library[c].getTitle() + " ? Svar med Y/N");
               // Console.WriteLine(library[c].getTitle());

            }
            //FormatException er hvis input ikke kan konverteres til en int
            catch (FormatException e)
            {
                Console.WriteLine("Forkert format i inputtet! Prøv igen!");
                goto start; //goto start; sender koden tilbage til start: labelet, indtil FormatException ikke sker
            }
            //ArgumentOutOfRangeException er hvis inputtet er over antallet af bøger
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Du skrev '" + (c + 1) + "' Men vi har kun 10 bøger! Prøv igen!");
                goto start;
            }



            List<Book> LentBooks = new List<Book>();
           // Console.WriteLine("Vil du låne bogen: " + library[c].getTitle() + " ? Svar med Y/N");
            string ja = Console.ReadLine().ToLower();
            string y = "y";
            string n = "n";
            if (string.Equals(ja, y))
            {
                string title = library[c].getTitle();
                string ISBN = library[c].getISBN();
                bool isLent = true;
                string author = library[c].getAuthor();
                string year = library[c].getYear();

              //  library[c].setIsLent = true;
                LentBooks.Add(new Book(title, ISBN, isLent, author, year));

                //LentBooks[0].setIsLent() = true;
            }
            else if (string.Equals(ja, n))
            {
                Console.WriteLine("Vælg en anden bog :)");
                goto start;
            }
            else
            {
                Console.WriteLine("Ikke forstået, vælg en anden bog :)");
                goto start;
            }
            int aa = 1;
            for (int i = 0; i < LentBooks.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Her er en liste over dine lånte bøger.");
                Console.WriteLine("Bog nr: " + aa);
                Console.WriteLine(LentBooks[i].getTitle());
                Console.WriteLine("By " + LentBooks[i].getAuthor());
                Console.WriteLine(LentBooks[i].getISBN());
                Console.WriteLine("Is it lent out? " + LentBooks[i].getIsLent());
                Console.WriteLine("The book is from: " + LentBooks[i].getYear());
                Console.WriteLine();
                aa++;

            }
            Console.ReadKey();

        restart:
            string l = "l";
                Console.WriteLine("Hvis vil du låne en mere bog, kan du svare med Y. Hvis du vil aflevere en bog, kan du svare med L. Hvis du vil afslutte kan du trykke på N Svar med Y/N :)");
                string mBooks = Console.ReadLine().ToLower();
            if (string.Equals(mBooks, y))
            {
                Console.WriteLine("Okay, Hvilken bog vil du låne ?");
                Console.WriteLine("*Tryk på hvilken som helst knap når du er klar til at få listen over bøger");
                Console.ReadKey();
                int aaa = 1;
                for (int mb = 0; mb < library.Count; mb++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bog nr: " + aaa);
                    Console.WriteLine(library[mb].getTitle());
                    Console.WriteLine("By " + library[mb].getAuthor());
                    Console.WriteLine(library[mb].getISBN());
                    Console.WriteLine("Is it lent out? " + library[mb].getIsLent());
                    Console.WriteLine("The book is from: " + library[mb].getYear());
                    Console.WriteLine();
                    aaa++;

                }

                Console.WriteLine("Hvilken bog vil du låne? (Angiv med hvad nummer den har i rækkefølgen)");

            start2:

                try
                {
                    string res = Console.ReadLine();
                    c = int.Parse(res);
                    c = c - 1;

                    Console.WriteLine("Vil du låne bogen: " + library[c].getTitle() + " ? Svar med Y/N");
                    // Console.WriteLine(library[c].getTitle());

                }
                //FormatException er hvis input ikke kan konverteres til en int
                catch (FormatException e)
                {
                    Console.WriteLine("Forkert format i inputtet! Prøv igen!");
                    goto start2; //goto start; sender koden tilbage til start: labelet, indtil FormatException ikke sker
                }
                //ArgumentOutOfRangeException er hvis inputtet er over antallet af bøger
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Du skrev '" + (c + 1) + "' Men vi har kun 9 bøger til udlån! Prøv igen!");
                    goto start2;
                }
                ja = Console.ReadLine().ToLower();
                if (string.Equals(ja, y))
                {
                    string title = library[c].getTitle();
                    string ISBN = library[c].getISBN();
                    bool isLent = true;
                    string author = library[c].getAuthor();
                    string year = library[c].getYear();

                    //  library[c].setIsLent = true;
                    LentBooks.Add(new Book(title, ISBN, isLent, author, year));

                    //LentBooks[0].setIsLent() = true;
                }
                else if (string.Equals(ja, n))
                {
                    Console.WriteLine("Vælg en anden bog :)");
                    goto start;
                }
                else
                {
                    Console.WriteLine("Ikke forstået, vælg en anden bog :)");
                    goto start;
                }
                int aaaaaaa = 1;
                for (int i = 0; i < LentBooks.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Her er en liste over dine lånte bøger.");
                    Console.WriteLine("Bog nr: " + aaaaaaa);
                    Console.WriteLine(LentBooks[i].getTitle());
                    Console.WriteLine("By " + LentBooks[i].getAuthor());
                    Console.WriteLine(LentBooks[i].getISBN());
                    Console.WriteLine("Is it lent out? " + LentBooks[i].getIsLent());
                    Console.WriteLine("The book is from: " + LentBooks[i].getYear());
                    Console.WriteLine();
                    aaaaaaa++;

                }
                Console.ReadKey();
            }
            
            
            else if (string.Equals(mBooks, n))
            {
                Console.WriteLine("Okay :)");
                Console.ReadKey();
            }
            else if (string.Equals(mBooks, l))
                {
                Console.ReadKey();
                    Console.WriteLine("Hvilken bog vil du aflevere, angiv med hvad nummer den har i rækkefølgen :)");

            delivery:

                try
                {
                    string res = Console.ReadLine();
                    c = int.Parse(res);
                    c = c - 1;
                    Console.WriteLine("Vil du aflevere bogen: " + library[c].getTitle() + " ? Svar med Y/N");
                    // Console.WriteLine(library[c].getTitle());

                }
                //FormatException er hvis input ikke kan konverteres til en int
                catch (FormatException e)
                {
                    Console.WriteLine("Forkert format i inputtet! Prøv igen!");
                    goto delivery; //goto start; sender koden tilbage til start: labelet, indtil FormatException ikke sker
                }
                //ArgumentOutOfRangeException er hvis inputtet er over antallet af bøger
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Du skrev '" + (c + 1) + "' Men du har kun " + LentBooks.Count() + " bøger! Prøv igen!");
                    goto delivery;
                }

                if (string.Equals(ja, y))
                {
                    string title = library[c].getTitle();
                    string ISBN = library[c].getISBN();
                    bool isLent = true;
                    string author = library[c].getAuthor();
                    string year = library[c].getYear();

                    //  library[c].setIsLent = true;
                    LentBooks.Add(new Book(title, ISBN, isLent, author, year));

                    //LentBooks[0].setIsLent() = true;
                }
                else if (string.Equals(ja, n))
                {
                    Console.WriteLine("Vælg en anden bog :)");
                    goto start;
                }
                else
                {
                    Console.WriteLine("Ikke forstået, vælg en anden bog :)");
                    goto start;
                }


            }
                else
            {
                Console.WriteLine("Ikke forstået, prøv igen :)");
                goto restart;
            }
            
            }

        }

    }

