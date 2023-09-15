using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    internal class SwimNot : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("\nHabilidad de nado: Glu, glu, glu... ");
        }
    }
}
