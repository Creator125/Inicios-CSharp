/*
 * Tema: Bucle for
 * 
 * Imprimir los numeros impares desede 0 hasta 20
*/
using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
