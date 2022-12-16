//Tema: Manejo de errores
using System;

namespace ManejoDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            string valor = Console.ReadLine();

            try{
                int num = Int32.Parse(valor);
            }
            catch (FormatException) //Si el formato es incorrecto
            {
                Console.WriteLine("El valor ingresado tiene un formato incorrecto");
            }
            catch (OverflowException) //Si el valor sufre un desbordamiento
            {
                Console.WriteLine("El numero ingresado es demasiado grande o demasiado corto");
            }
            catch (ArgumentNullException) //Si no se ingresó un valor
            {
                Console.WriteLine("No se ha ingresado nigún valor");
            }
            finally
            {
                Console.WriteLine("Esta palabra aparecera pase lo que pase");
            }

            Console.Read();
        }
    }
}
