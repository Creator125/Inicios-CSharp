using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColordeConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definiendo colores
            Console.ForegroundColor = ConsoleColor.Yellow; //Color de letra
            Console.BackgroundColor = ConsoleColor.DarkBlue; //Color de letra
            Console.Clear(); //Para que el color de fondo ocupará toda la pantalla

            Console.WriteLine("Hola mundo");
            Console.Read();
        }
    }
}
