//Tema: Toma de descisiones
using System;

namespace TomaDeDecisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 40;

            if (temperatura < 40)
            {
                Console.WriteLine("Pararece enfiarse todo");
            }
            if(temperatura == 40)
            {
                Console.WriteLine("Hace mucho calor");
            }
            if (temperatura > 40)
            {
                Console.WriteLine("Las palomas se estan cocinando");
            }

            Console.Read();
        }
    }
}
