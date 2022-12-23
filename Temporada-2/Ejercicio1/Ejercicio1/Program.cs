/*
 * Tema: Tipo de datos texto
 * 
 * Crear una variable que contega el metodo necesario necesario 
 * para hacer que el mensaje pase a minuscula 
 */

using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "Creator125";
            string texto = "Hola soy ";
            string mayuscula = usuario.ToUpper();
            string minuscula = usuario.ToLower();

            Console.WriteLine(texto + usuario);
            Console.WriteLine(minuscula);
            Console.Read();
        }
    }
}
