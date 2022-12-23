//Tema: Parsing de string a integer (int)
using System;

namespace ConvertirStringAInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "20";
            string texto2 = "48";
            string resultado = texto1 + texto2;

            //Realizando la conversionesde los string a int
            int num1 = Int32.Parse(texto1);
            int num2 = Int32.Parse(texto2);
            int resultadoN = num1 + num2;

            Console.WriteLine(resultadoN);
            Console.Read();
        }
    }
}
