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

            //Humano sin apellido
            Humano persona1 = new Humano("Juan", "Verdes", 23);
            //Humano sin apellido y color de ojos
            Humano persona2 = new Humano("Tatiana", 30);
            //Humano completo
            Humano persona3 = new Humano("Obed", "Códoba", "Negros", 21);

            persona1.presentarme();
            persona2.presentarme();
            persona3.presentarme();

            Console.Read();
        }
    }
}
