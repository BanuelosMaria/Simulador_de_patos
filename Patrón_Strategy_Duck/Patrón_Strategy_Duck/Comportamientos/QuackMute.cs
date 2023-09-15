using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    internal class QuackMute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("\nHabilidad para graznar:... *Inserte lenguaje de señas de patos*...");
        }
    }
}
