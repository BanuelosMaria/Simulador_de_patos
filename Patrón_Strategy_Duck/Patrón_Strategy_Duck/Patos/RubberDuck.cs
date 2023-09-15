using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackMute();
            swimBehavior = new SwimNot();
        }

        public override void Display()
        {
            Console.WriteLine("Usted a seleccionado: RubberDuck \nGOMU-GOMU-QUAAAAACK!!!!");
        }
    }
}
