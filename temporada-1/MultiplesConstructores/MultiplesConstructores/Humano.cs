using System;

namespace MultiplesConstructores
{
    internal class Humano
    {
        //Mienbro Variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        //Contructor no parametrizado o por defecto
        public Humano()
        {
            Console.WriteLine("Contructor llamado, objeto creado");
        }
        
        //Miembro constructor paramtrizado
        public Humano(string PrimerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = PrimerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        public Humano(string PrimerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = PrimerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
        }

        //Miembro Metodo
        public void presentarme()
        {
            if (edad != 0)
            {
                Console.WriteLine("Hola, soy " + primerNombre + " "
                                + apellido + ", tengo ojos " + colorOjos + " y tengo " + edad
                                + " año");
            }
            else
            {
                Console.WriteLine("Hola, soy " + primerNombre + " "
                                + apellido + ", tengo ojos " + colorOjos);
            }
        }

    }
}