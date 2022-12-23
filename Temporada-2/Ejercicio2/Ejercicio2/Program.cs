/*
Tema: Ingreso de usuario

Crea un progama que le pida al usuario que ingrese un valor numerico
y luego le pida otro valor más y muestre la suma de esos dos valores
 */
using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor1, valor2;

            Console.WriteLine("Ingrese el primer numero");
            valor1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            valor2 = Console.ReadLine();

            //Convirtiendo los valores a entero para sumarlos
            int num1 = Int32.Parse(valor1);
            int num2 = Int32.Parse(valor2);
            int suma = num1 + num2;

            Console.WriteLine("Suma de los valores ingresados: "+ suma);
            Console.Read();
        }
    }
}
