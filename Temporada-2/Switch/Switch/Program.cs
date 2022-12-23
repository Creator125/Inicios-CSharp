//Tema: Declaración switch
using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = 3;

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Hoy es lunes");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Martes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es miercoles");
                    break;
                default:
                    Console.WriteLine("No hay día asociado");
                    break;
            }

            Console.Read();
        }
    }
}
