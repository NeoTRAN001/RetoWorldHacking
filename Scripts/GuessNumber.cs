using System;

namespace RetoKike.Scripts
{
    class GuessNumber
    {
        private string IsANumber(int number, int userValue) {
            if(number > userValue) return "TOO_SMALL";
            if(number < userValue) return "TOO_BIG";
            return "¡¡¡ CORRECT !!!";
        }
        public void run() {
            int[] range = new int[2];
            string result = String.Empty;

            int attempts = Props.Input("¿Cuantos intentos quiere?: ");
            range[0] = Props.Input("Ingrese el inicio del rango: ");
            range[1] = Props.Input("Ingrese el final del rango: ");

            if (Props.ValidateGuessNumber(range, attempts)) {
                Console.WriteLine("Datos no validos");
                return;
            }

            int number = new Random().Next(range[0], range[1]);

            for (int i = 0; i < attempts; i++) {
                Console.WriteLine("\n\nNumero de intentos: " + (attempts - i));
                result = IsANumber(number, Props.Input("Entrada: "));

                Console.WriteLine("\n\n" + result);
                if (result == "¡¡¡ CORRECT !!!") break;
            }
        }
    }
}
