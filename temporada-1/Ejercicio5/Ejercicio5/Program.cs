/*
Tema: Sentecia switch

Replicar el algoritmo de switch mostrado en el video

Parte del video: 2:30:00
 */
using System;


namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int autos = 5;

            if (autos == 0)
            {
                Console.WriteLine("Usted no paga impuestos");
            }
            else if (autos == 1)
            {
                Console.WriteLine("Uste paga $15");
            }
            else if (autos == 2)
            {
                Console.WriteLine("Usted paga $30");
            }
            else
            {
                Console.WriteLine("Usted paga $15 dolares por auto");
            }

            Console.Read();
        }
    }
}
