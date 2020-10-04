using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Element <T>
    {



        public T Value { get; set; }
        public Element<T> next { get; set; }



    }
}
