//Tema: Constructores
using System;

namespace Constructores
{
    class Humano
    {
        //Mienbro Variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        //Miembro constructor
        public Humano( string PrimerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = PrimerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        //Miembro Metodo
        public void presentarme()
        {
            if(edad == 1)
            {
                Console.WriteLine("Hola, soy " + primerNombre + " "
                                + apellido + ", tengo ojos " + colorOjos + " y tengo " + edad
                                + " año");
            }
            else
            {
                Console.WriteLine("Hola, soy " + primerNombre + " " 
                                + apellido +", tengo ojos "+ colorOjos +" y tengo "+ edad
                                +" años");
            }

            
        }
    }
}