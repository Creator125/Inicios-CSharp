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

        //Contructor sin apellido
        public Humano(string PrimerNombre, string colorOjos, int edad)
        {
            this.primerNombre = PrimerNombre;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        //Contructor sin apellido y color de ojos
        public Humano(string PrimerNombre, int edad)
        {
            this.primerNombre = PrimerNombre;
            this.edad = edad;
        }

        //Miembro Metodo
        public void presentarme()
        {
            if (edad != 0 && apellido != null && colorOjos != null){
                Console.WriteLine("Hola, soy " + primerNombre + " "
                                + apellido + ", tengo ojos " + colorOjos + " y tengo " + edad
                                + " años");
            }
            else if (apellido == null && colorOjos == null)
            {
                Console.WriteLine("Hola, soy " + primerNombre + " y tengo " + edad + " años");
            }
            else if (apellido == null){
                Console.WriteLine("Hola, soy " + primerNombre + ", tengo ojos " + colorOjos + " y tengo " + edad
                                + " años");
            }else{
                Console.WriteLine("Hola, soy " + primerNombre + " "
                                + apellido + "y tengo ojos " + colorOjos);
            }
        }

    }
}