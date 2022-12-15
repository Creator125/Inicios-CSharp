//Tema: Metodos con retorno
using System;

namespace MetodosConRetorno
{
    internal class Program
    {
        public static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public static double dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

        static void Main(string[] args)
        {
            //Sumando con metodos
            Console.WriteLine(sumar(56, 23));
            //Multiplicando con metodos
            Console.WriteLine(multiplicar(5, 10));
            //Dividiendo con metodos
            Console.WriteLine(dividir(10, 2));
            Console.Read();
        }
    }
}
