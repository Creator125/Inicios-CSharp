//Tema: Clases y Objetos
using System;

namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Crear un objeto desde clase
            //Instacia de Humano
            Humano persona1 = new Humano();
            //Acceder a una variable publica externa
            persona1.primerNombre = "Juan";
            //Llamar a un método de la clase
            persona1.presentarme();

            Humano persona2 = new Humano();
            persona2.primerNombre = "Valentina";
            persona2.presentarme();
            */

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
