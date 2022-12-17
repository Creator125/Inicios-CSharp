/*
 * Tema: Bucle While
 * 
 * Contar de 1 en 1 a medida que el usuario presiona ENTER
 */
using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string text = "";

            while (text.Equals(""))
            {
                Console.WriteLine("Presione ENTER para seguir contando y" +
                    " para salir ingrese otro valor");
                text = Console.ReadLine();
                i++;
                Console.WriteLine(i);
            }
            Console.WriteLine("Ultimo numero contado: "+ i);

            Console.Read();
        }
    }
}
