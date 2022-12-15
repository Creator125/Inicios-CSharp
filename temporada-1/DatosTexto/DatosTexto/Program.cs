using System;

namespace DatosTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "Creator125";
            string texto = "Hola soy ";
            string mayuscula = usuario.ToUpper();

            Console.WriteLine(texto + usuario);
            Console.WriteLine(mayuscula);
            Console.Read();
        }
    }
}
