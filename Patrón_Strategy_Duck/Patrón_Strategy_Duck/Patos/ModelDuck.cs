using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new QuackMute();
            swimBehavior = new SwimNot();
        }

        public override void Display()
        {
            Console.WriteLine("Usted a seleccionado: ModelDuck \nEn realidad... soy un modelo, ayuda. NO SOY UN PATO!!!!");
        }
    }
}
