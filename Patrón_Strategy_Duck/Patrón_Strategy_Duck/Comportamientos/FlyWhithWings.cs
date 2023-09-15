using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    public class FlyWhithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("\nHabilidad para volar:Vuelo con mis alitas de pato");
        }
    }
}
