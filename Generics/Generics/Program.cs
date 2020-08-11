using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericsEx<int> dild = new GenericsEx<int>(69);
            dild.writeText<string>(101, "HelloWorld");
        }
    }
}
