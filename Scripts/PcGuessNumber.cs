using System;
using System.Collections.Generic;

namespace RetoKike.Scripts
{
    class PcGuessNumber
    {
        private string IsANumber(int number) {
            Console.WriteLine("Mayor [>] - Menor [<] - Correcto [=]");

            return Props.InputStr("¿Su número es "+number+"?: ");;
        }
        public void run() {
            List<int> lstRange = new List<int>();
            int[] range = new int[2];
            string result = String.Empty;

            int attempts = Props.Input("¿Cuantos intentos quiere?: ");
            range[0] = Props.Input("Ingrese el inicio del rango: ");
            range[1] = Props.Input("Ingrese el final del rango: ");

            if (Props.ValidateGuessNumber(range, attempts)) {
                Console.WriteLine("Datos no validos");
                return;
            }

            for (int i = range[0]; i <= range[1]; i++) lstRange.Add(i);

            for (int i = 0; i < attempts; i++) {
                int count = lstRange.Count;
                int number = count / 2;
                string question = IsANumber(lstRange[number]);

                if(question == ">") 
                    for(int j = number; j >= 0; j--)
                        lstRange.Remove(lstRange[j]);

                else if (question == "<")
                    for(int j = number; j < count; j++)
                        lstRange.RemoveAt(lstRange.Count - 1);

                else if (question == "=") {Console.WriteLine("He ganado!!"); break;}
            }
        }
    }
}