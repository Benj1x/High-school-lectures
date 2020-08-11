using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericsEx<T> where T: struct
    {
        private T value = default(T);
        public GenericsEx(T value)
        {
            this.value = value;
        }

        private T getValue()
        {
            return value;
        }

        public T writeText<U>(T text, U defaultValue)
        {
            Console.WriteLine();
            return text;
            
        }
    }
}
