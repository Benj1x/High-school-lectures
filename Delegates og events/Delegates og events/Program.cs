using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_og_events
{
    class Program
    {
        public delegate string DelegateMethodInvoke(string text);
        static void Main(string[] args)
        {
            Console.WriteLine(callMethodsViaDelegate());
            A text = new A();
            string result = text.printText("Not used");
            A.MethodInvoke += OnPrintText;
            Console.ReadKey();
        }

        public static string printText(string text)
        {
            return "Hej";
        }

        public static string callMethodsViaDelegate()
        {
            DelegateMethodInvoke methodInvoke = new DelegateMethodInvoke(printText);
            string result = methodInvoke.BeginInvoke("Halløjsa");
            return result;
        }
        private static void OnPrintText(object sender, EventArgs args)
        {
            Console.WriteLine("Success");
        }
    }
}
