using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Comportamientos
{
    internal class Quackity : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("\nHabilidad para graznar:Yo le hago Quackity, Quackity");
        }
    }
}
