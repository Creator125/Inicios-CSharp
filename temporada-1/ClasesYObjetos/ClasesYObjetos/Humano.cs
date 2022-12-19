using System;

namespace ClasesYObjetos
{
    class Humano
    {
        //Mienbro Variable
        public string primerNombre;
        public string apellido;

        //Miembro Metodo
        public void presentarme()
        {
            Console.WriteLine("Hola, soy "+ primerNombre +" "+ apellido);
        }
    }
}
