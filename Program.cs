using RetoKike.Scripts;
using System;

namespace RetoKike
{
    class Program
    {
        static int Menu() {
            Console.WriteLine("\n****** Reto de World Hacking by Tux ******\n");
            Console.WriteLine("Etapa 1:\n"+
                               " 1- Adivinar el número\n"+
                               " 2- Pepe quiere una calculadora\n"+
                               " 3- Robot\n");

            Console.Write("Option: ");
            return Convert.ToUInt16(Console.ReadLine());;
        }

        static void Main(string[] args)
        {
            int option = Menu();

            switch(option)
            {
                case 1: new GuessNumber().run(); break;
                case 2: new CalculatorPepes().run(); break;
            }
        }
    }
}
