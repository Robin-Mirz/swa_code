using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOExample.Animals
{
    public class Cat : Animal
    {

        public override string MakeNoise()
        {
            return "MIAU!";
        }
        public Cat(string name) : base(name)
        {
        }

        public override string  Move()

        {

            return "run like a cat";

        }
    }
}
