using System;

namespace DatosNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos enteros
            int num1 = 10;
            int num2 = 5;
            int suma = num1 + num2;

            //Datos decimales
            double deci1 = 3.4;
            double deci2 = 1.599;
            double sumad = deci1+ deci2;

            Console.WriteLine("La suma de "+ num1 +" + "+ num2 +" = "+ suma);
            Console.WriteLine("La suma de " + deci1 + " + " + deci2 + " = " + sumad);
            Console.Read();
        }
    }
}
