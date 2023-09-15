using Patrón_Strategy_Duck.Comportamientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck.Patos
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        protected ISwimBehavior swimBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformSwim()
        {
            swimBehavior.Swim();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void SetSwimBehavior(ISwimBehavior sb)
        {
            swimBehavior = sb;
        }
    }
}
