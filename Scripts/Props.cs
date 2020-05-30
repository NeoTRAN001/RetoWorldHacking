using System;

namespace RetoKike.Scripts
{
    class Props
    {
        public static int Input(string message) {
            try {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch {
                Console.WriteLine("\nSegurarse de ingresar los datos de forma correcta\n");
                return Input(message);
            }
        }

        public static bool ValidateGuessNumber(int[] range, int attempts) {
            if (attempts <= 0) return true;
            if(attempts >= 100) return true;
            if (range[0] >= range[1]) return true;
            else if (range[0] <= 0) return true;
            return false;
        }
    }
}