using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehavior = new FlyWhithWings();
            quackBehavior = new QuackNormal();
            swimBehavior = new SwimNot();

        }
        public override void Display()
        {
            Console.WriteLine("Usted a seleccionado: ReadHeadDuck \nYo, yo soy un patito de cabeza roja... creo, no tengo espejo");
        }
    }
}
