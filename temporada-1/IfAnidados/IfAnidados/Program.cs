//Tema:If anidados
using System;

namespace IfAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string usuario = "";

            Console.WriteLine("Ingrese el nombre de usuario");
            usuario = Console.ReadLine();

            if (estaRegistrado)
            {
                Console.WriteLine("Hola usurio registrado");

                if (usuario != "")
                {
                    Console.WriteLine("Hola " + usuario);

                    if (usuario.Equals("Admin"))
                    {
                        Console.WriteLine("Hola Admin");
                    }
                }
            }

            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("Esta logueado");
            }

            Console.Read();
        }
    }
}
