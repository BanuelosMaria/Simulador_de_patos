using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    public class SwimWithLegs : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("\nHabilidad de nado: Yo nado con mis patitas.");
        }
    }
}
