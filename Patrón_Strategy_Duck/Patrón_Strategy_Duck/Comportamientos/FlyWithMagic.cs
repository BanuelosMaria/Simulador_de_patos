using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    public class FlyWithMagic : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("\nHabilidad para volar:Yo puedo volar con el poder del guion");
        }
    }
}
