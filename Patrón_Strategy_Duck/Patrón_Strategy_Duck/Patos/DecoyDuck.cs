using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackMute();
            swimBehavior = new SwimNot();
        }

        public override void Display()
        {
            Console.WriteLine("Usted a seleccionado: DecoyDuck \nNo quiero hacer nada, solo quiero dormir...");
        }
    }
}
