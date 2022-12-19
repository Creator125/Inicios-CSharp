//Tema: Break y continue
using System;

namespace BreakYContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                /*
                if (i == 5)
                {
                    //Console.WriteLine("Al llegar al 5 nos detenemos");
                    //break;
                    Console.WriteLine("Saltamos el 5");
                    continue;
                }
                */

                if (i % 2 == 0)
                {
                    Console.WriteLine("El proximo es impar");
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
