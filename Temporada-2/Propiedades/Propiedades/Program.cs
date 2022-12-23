//Tema: Propiedades
using System;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(19, 45, 56);
            caja.VerInfo();

            Console.WriteLine("El volumen es de {0}",caja.Volumen);
            Console.Read();
        }
    }
}
