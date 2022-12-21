using System;

namespace Propiedades
{
    class Caja
    {
        //Miembro variables
        private string color = "Marron";
        private int largo;
        private int alto;
        //private int ancho;
        private int volumen;

        public Caja(int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.Ancho = ancho;
        }

        public int Volumen 
        {
            set
            {
                volumen = value;
            }
            get
            {
                return Alto * Ancho * Largo;
            }
            
            
        }

        public int Alto {
            get 
            {
                return alto;
            }
            /*
            set
            {
                if (value < 0) value = -value; //throw new Exception("El tamanño debe ser positivo");
                alto = value;
            } 
            */
        }

        //Propiedad auto implementada
        public int Ancho { get; set; }

        /*
        public int Largo
        {
            get { return largo;}
            set { largo = value; }
        }
        */

        public int Largo
        {
            get => largo;
            set => largo = value;
        }

        //Miembro metodo
        public void VerInfo()
        {
            Console.WriteLine("El largo es {0}." +
                " La altura es {1}. " +
                "El ancho es {2}. " +
                "Por lo tanto el volumen es {3}",
                largo, alto, Ancho, volumen = Ancho * alto * largo);
        }

        /*
        public void Setlargo(int largo)
        {
            this.largo = largo;
        }

        public void Getlargo()
        {
            return this.largo;
        }
        */
    }
}
