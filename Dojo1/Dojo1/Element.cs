using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Element <T>
    {

        public Element(T value, Element<T> next)
        {
            Value = value;
            Next = next;
            
        }

        public T Value { get; set; }
        public Element<T> Next { get; set; }



    }
}
