//Tema: Multiples constructores
using System;

namespace MultiplesConstructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humanoBasico = new Humano("Jorge", "Ortega", "Vedes");
            humanoBasico.presentarme();

            Console.Read();
        }
    }
}
