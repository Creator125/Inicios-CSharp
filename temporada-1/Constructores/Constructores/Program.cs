//Tema: Constructores
using System;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primera instacia
            Humano persona1 = new Humano();
            persona1.primerNombre = "Obed";
            persona1.apellido = "Cordoba";
            persona1.presentarme();

            //Segunda instacia
            Humano persona2 = new Humano();
            persona2.primerNombre = "Viviana";
            persona2.apellido = "Palacios";
            persona2.presentarme();

            Console.Read();
        }
    }
}
