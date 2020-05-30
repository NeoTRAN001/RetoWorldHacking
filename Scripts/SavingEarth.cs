using System;
using System.Collections.Generic;
using System.Text;

namespace RetoKike.Scripts
{
    class SavingEarth
    {
        int Attempts { get; set; }
        int Shield { get; set; }
        string Robot { get; set; }
        /// <summary>
        /// Devolverá 1 de 3 posibles valores enteros, dependiendo la estructura de la cadena
        /// del robot, si contiene solamente - S - será de tipo 0, si contiene solamente - C -
        /// será de tipo 1 y si es una combinación tipo 2
        /// </summary>
        /// <returns>El número del tipo de cadena</returns>
        private int GetStringType()
        {
            bool thereIsAC = Robot.Contains("C");
            bool thereIsAS = Robot.Contains("S");

            if (thereIsAC && thereIsAS) return 2;
            else if (thereIsAC) return 1;
            else if (thereIsAS) return 0;

            return 3;
        }
        /// <summary>
        /// Nos dice el daño total que va a generar el robot en la cadena actual
        /// </summary>
        private int GetTotalDamage()
        {
            int power = 1;
            int total = 0;

            foreach(char c in Robot)
            {
                if (c == 'C') power *= 2;
                if (c == 'S') total += power;
            }

            return total;
        }

        private int GetMinimumNumber()
        {
            int quantity = 0, index = 0;
            char[] aux = Robot.ToCharArray();


            while (GetTotalDamage() > Shield)
            {
                if (index == Robot.Length) return -1;

                index = 0;

                foreach (char c in Robot)
                {
                    if (c == 'C')
                        if(index != Robot.Length-1)
                            if (aux[index + 1] != 'C')
                            {
                                aux[index] = 'S';
                                aux[index + 1] = 'C';
                                quantity++;
                                break;
                            }
                    index++;
                }
                Robot = new string(aux);
            }

            return quantity;
        }

        public void run()
        {
            Attempts = Props.Input("¿Cuantos intentos quiere?: ");

            for(int i = 0; i < Attempts; i++)
            {
                Shield = Props.Input("¿Cuanto daño puede soportar el escudo?: ");
                Robot = Props.InputStr("Instrucción del robot: ").ToUpper();

                if (Props.ValidateSavingEarth(Attempts, Shield, Robot))
                {
                    Console.WriteLine("\n\nDatos no validos según las reglas");
                    return;
                }

                switch (GetStringType())
                {
                    case 0:
                        if(GetTotalDamage() > Shield) Console.WriteLine("IMPOSSIBLE");
                        else Console.WriteLine("0");
                        break;
                    case 1: Console.WriteLine("Ganaste, pues solamente ha recargado XD"); break;
                    case 2:
                        int result = GetMinimumNumber();
                        if (result >= 0) Console.WriteLine("\nR: {0} \nString: {1}", result, Robot);
                        else Console.WriteLine("IMPOSIBLE");
                        break;
                }
            }
        }
    }
}
