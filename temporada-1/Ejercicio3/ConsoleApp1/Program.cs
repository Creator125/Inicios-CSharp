/*
Tema: Manejo de errores

Hacer un progama que divida un numero por 0 (esto dará un error); prevenir
ese error dependiendo de su tipo
*/
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 0, resultado;

            try
            {
               resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede divir por 0");
            }

            Console.Read();
        }
    }
}
