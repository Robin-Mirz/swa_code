using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo1
{
    class Stack<T>
    {
        //Attribute
        private Element<T> aktuell { get; set; }

        //Methoden

        public void Push(T element)
        {
            if(aktuell == null)
            {
                aktuell = new Element<T>() { Value = element, next = null };

            }
            else
            {
                Element<T> tmp = new Element<T>() { Value = element, next = aktuell };
                aktuell = tmp;
            }



        }

        public T Pop()
        {
        if(aktuell != null)
            {
                T tmp = aktuell.Value;
                aktuell = aktuell.next;
                return tmp;


            }

            else
            {
                return default(T);

            }


        }

        public T Peek()
        {
            if(aktuell != null)
            {
                return aktuell.Value;
            }
            else
            {
                return default(T);
            }


        }
    }
}
