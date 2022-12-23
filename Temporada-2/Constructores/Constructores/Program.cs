//Tema: Constructores
using System;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano persona1 = new Humano("Obed", "Cordoba", "Negros", 21);
            persona1.presentarme();

            Humano persona2 = new Humano("Valentina", "Palacios", "Cafe", 20);
            persona2.presentarme();

            Humano persona3 = new Humano("Carlos", "Garcia", "Azules", 17);
            persona3.presentarme();

            Humano persona4 = new Humano("Jorge", "Ortega", "Vedes", 1);
            persona4.presentarme();

            Console.Read();
        }
    }
}
