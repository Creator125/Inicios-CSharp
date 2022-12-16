/*
 * Tema: Toma de desiciones
 * 
 * Crear un progama en donde el usuario ingresa una temperatua y de acuerdo
 * a ella se le de una recomendacion de una ropa a usar
*/
using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una temperatuura");
            string valor = Console.ReadLine();

            int temperatura = Int32.Parse(valor);

            if (temperatura < 10)
            {
                Console.WriteLine("Abrigate");
            }
            if (temperatura == 10)
            {
                Console.WriteLine("Hace mucho calor");
            }
            if (temperatura > 10)
            {
                Console.WriteLine("Las palomas se estan cocinando");
            }

            Console.Read();
        }
    }
}
