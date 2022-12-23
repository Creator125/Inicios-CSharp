/*
 * Tema: Toma de desiciones
 * 
 * Crear un progama en donde el usuario ingresa una temperatua y de acuerdo
 * a ella se le de una recomendacion de que clase de ropa a usar
*/
using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una temperatura");
            string valor = Console.ReadLine();
            int temperatura = Int32.Parse(valor);

            if (temperatura < 20)
            {
                Console.WriteLine("Abrigate");
            }
            if (temperatura == 20)
            {
                Console.WriteLine("Vistete comodo");
            }
            if (temperatura > 20)
            {
                Console.WriteLine("Use ropa bien liviana");
            }

            Console.Read();
        }
    }
}
