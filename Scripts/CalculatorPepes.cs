using System;

namespace RetoKike.Scripts
{
    class CalculatorPepes
    {
        public void run() {
            int cases = Props.Input("Ingrese el número de casos: ");

            for(int i = 0; i < cases; i++) {
                int K = Props.Input("Ingrese K: ");
                int J = Props.Input("Ingrese J: ");

                if (0 > K || J < 0) {
                    Console.WriteLine("\n\n Datos no validos del caso "+ (i+1) + " \n\n");
                    continue;
                }

                Console.WriteLine("\nCaso " + (i+1) + " R: " + (K + J) + "\n\n");
            }
        }
    }
}