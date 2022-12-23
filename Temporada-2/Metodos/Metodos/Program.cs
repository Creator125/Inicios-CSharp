//Tema: Metodos
using System;

namespace Metodos
{
    internal class Program
    {
        //Metodo vacio
        public static void EscribirTexto()
        {
            Console.WriteLine("Hola desde otro metodo");
        }

        //Metodo vacio con argumento
        public static void Escribir(string texto)
        {
            Console.WriteLine(texto);
        }

        static void Main(string[] args)
        {
            EscribirTexto();
            Escribir("Hola mundo");
            Console.Read();

        }
    }
}
