using RetoKike.Scripts;
using System;

namespace RetoKike
{
    class Program
    {
        static int Menu() {
            Console.WriteLine("\n****** Reto de World Hacking by Tux ******\n");
            Console.WriteLine("\nEtapa 1:\n"+
                               " [1]  - Tienes que adivinar el número\n"+
                               " [2]  - La PC adivina el número\n"+
                               " [3]  - Pepe quiere una calculadora\n"+
                               " [4]  - Robot\n" +
                               " [99] - Salir\n");

            Console.Write("Option: ");
            return Convert.ToUInt16(Console.ReadLine());;
        }

        static void Main(string[] args)
        {
            try
            {
                bool infinite = true;
                while (infinite)
                {
                    switch (Menu())
                    {
                        case 1: new GuessNumber().run(); break;
                        case 2: new PcGuessNumber().run(); break;
                        case 3: new CalculatorPepes().run(); break;
                        case 4: new SavingEarth().run(); break;
                        default: infinite = false; break;
                    }
                }
            }
            catch { Console.WriteLine("Opción no valida"); }
        }
    }
}
