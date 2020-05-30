using RetoKike.Scripts;
using System;

namespace RetoKike
{
    class Program
    {
        static int Menu() {
            Console.WriteLine("\n****** Reto de World Hacking by Tux ******\n");
            Console.WriteLine("\n\nEtapa 1:\n"+
                               " [1]- Adivinar el número\n"+
                               " [2]- Pepe quiere una calculadora\n"+
                               " [3]- Robot\n" +
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
                        case 2: new CalculatorPepes().run(); break;
                        case 3: new SavingEarth().run(); break;
                        default: infinite = false; break;
                    }
                }
            }
            catch { Console.WriteLine("Opción no valida"); }
        }
    }
}
