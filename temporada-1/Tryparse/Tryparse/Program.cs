//Tema: If y else con Tryparse
using System;

namespace Tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una temperatura");
            string valor = Console.ReadLine();
            int temperatura;

            int numero;

            if (int.TryParse(valor, out numero))
            {
                temperatura = numero;
            }
            else
            {
                temperatura = 0;

                Console.WriteLine("El valor ingresado no es valido, por favor vuelva a intentarlo con un valor numerico");
            }

            if (temperatura < 20)
            {
                Console.WriteLine("Abrigate");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("Vistete comodo");
            }
            else
            {
                Console.WriteLine("Use ropa bien liviana");
            }

            Console.Read();
        }
    }
}
