using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public class MallardDuck :Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithMagic();
            quackBehavior = new Quackity();
            swimBehavior = new SwimWithPromoters();

        }

        public override void Display()
        {
            Console.WriteLine("Usted a seleccionado: MallarDuck \nUn placer, yo soy un pato... mejor que los demas");
        }
    }
}
