using Patrón_Strategy_Duck.Comportamientos;
using Patrón_Strategy_Duck.Patos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Strategy_Duck
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Duck mallardDuck = new MallardDuck();
                Duck readheadDuck = new RedHeadDuck();
                Duck decoyDuck = new DecoyDuck();
                Duck modelDuck = new ModelDuck();
                Duck rubberDuck = new RubberDuck();

                Console.WriteLine("\t---BIENVENIDO AL SIMULADOR DE PATOS---");
                Console.WriteLine("\nEn este simulador te mostraremos como ser un pato");
                Console.WriteLine("Volar, hablar y nadar como pato... dependiendo el pato que seas, claro esta.");
                Console.WriteLine("A continuacion seleciona el pato que deseas ser\n\tMenú ");
                Console.WriteLine("1. Mallard Duck");
                Console.WriteLine("2. RedHead Duck");
                Console.WriteLine("3. Decoy Duck");
                Console.WriteLine("4. Model Duck");
                Console.WriteLine("5. Rubber Duck");
                Console.Write("¿Qué pato desea ser? ");

                int opcion = int.Parse(Console.ReadLine());

                Duck selecedDuck = null;
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        selecedDuck = mallardDuck;
                        break;
                    case 2:
                        selecedDuck = readheadDuck;
                        break;
                    case 3:
                        selecedDuck = decoyDuck;
                        break;
                    case 4:
                        selecedDuck = modelDuck;
                        break;
                    case 5:
                        selecedDuck = rubberDuck;
                        break;
                    default:
                        Console.WriteLine("Esa no es una opcion, intenta de nuevo.");
                        Console.ReadKey();
                        break;
                }


                if (selecedDuck != null)
                {
                    selecedDuck.Display();
                    selecedDuck.PerformFly();
                    selecedDuck.PerformQuack();
                    selecedDuck.PerformSwim();
                    Console.ReadKey();

                    Console.Clear();

                    // Cambio de Vuelo

                    Console.WriteLine("\nCambiar comportamiento de vuelo \n1. Con alas \n2. Sin vuelo \n3. Con magia ");
                    Console.Write("\n¿Qué comportamiento desea ser?");
                    int flyChoice = int.Parse(Console.ReadLine());

                    if (flyChoice == 1)
                    {
                        selecedDuck.SetFlyBehavior(new FlyWhithWings());
                    }
                    else if (flyChoice == 2)
                    {
                        selecedDuck.SetFlyBehavior(new FlyNoWay());
                    }
                    else if (flyChoice == 3)
                    {
                        selecedDuck.SetFlyBehavior(new FlyWithMagic());
                    }
                    Console.WriteLine("\nNuevo comportamiento de vuelo:");
                    //selecedDuck.PerformFly();
                    Console.Clear();

                    //Cambio de granzido
                    Console.WriteLine("\nCambiar comportamiento de graznido \n1. Quack Normal \n2. Silencio \n3. Que diga -Quackity- ");
                    Console.Write("\n¿Qué comportamiento desea ser?");
                    int QucakChoice = int.Parse(Console.ReadLine());

                    if (QucakChoice == 1)
                    {
                        selecedDuck.SetQuackBehavior(new QuackNormal());
                    }
                    else if (QucakChoice == 2)
                    {
                        selecedDuck.SetQuackBehavior(new QuackMute());
                    }
                    else if (QucakChoice == 3)
                    {
                        selecedDuck.SetQuackBehavior(new Quackity());
                    }
                    Console.WriteLine("\nNuevo comportamiento de graznido:");
                    //selecedDuck.PerformQuack();
                    Console.Clear();

                    //Cambio de nado
                    Console.WriteLine("\nCambiar comportamiento de nado \n1. Nadar \n2. hundirse \n3. con propursores");
                    Console.Write("\n¿Qué comportamiento desea ser?");
                    int SwimChoice = int.Parse(Console.ReadLine());

                    if (SwimChoice == 1)
                    {
                        selecedDuck.SetSwimBehavior(new SwimWithLegs());
                    }
                    else if (SwimChoice == 2)
                    {
                        selecedDuck.SetSwimBehavior(new SwimNot());
                    }
                    else if (SwimChoice == 3)
                    {
                        selecedDuck.SetSwimBehavior(new SwimWithPromoters());
                    }
                    Console.WriteLine("\nNuevo comportamiento de nado:");
                    //selecedDuck.PerformSwim();
                    Console.Clear();
                    selecedDuck.Display();
                    selecedDuck.PerformFly();
                    selecedDuck.PerformQuack();
                    selecedDuck.PerformSwim();

                    Console.WriteLine("\n\nGracias por usar nuestro simulador, presione >>ENTER<< para salir");
                    Console.ReadKey();
                }
            
         
        }
    }
}
