using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    internal class SwimWithPromoters : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("\nHabilidad de nado: Yo nado con propursores");
        }
    }
}
