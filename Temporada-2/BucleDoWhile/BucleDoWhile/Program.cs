//Tema: Bucle do while
using System;

namespace BucleDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 5;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 30);
            */

            int LargoTexto = 0;
            string textoCompleto = "";

            do
            {
                Console.WriteLine("Ingrese un nombre");

                string nombre = Console.ReadLine();
                int largoActual = nombre.Length;
                LargoTexto += largoActual;
                textoCompleto += nombre;
            } while (LargoTexto < 20);

            Console.WriteLine("Grasias "+ textoCompleto);

            Console.Read();

        }
    }
}
