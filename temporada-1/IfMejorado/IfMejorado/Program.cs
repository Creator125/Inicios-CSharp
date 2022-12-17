//Tema: Declaracion if mejorada
using System;

namespace IfMejorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temparatura = -5;
            string estado;

            /*
             //Codicional if comun
            if (temparatura < 0){
                estado = "Solido";
            }else{
                estado = "Liquido";
            }

            Console.WriteLine("Estado del agua: " + estado);
            Console.Read();
            */

            //Condicional if mejorada
            temparatura += 200;

            estado = temparatura >= 100 ? "Gaseoso" : temparatura < 0 ? "Solido": "Liquido";

            Console.WriteLine("Estado del agua: " + estado);
            Console.Read();
        }
    }
}
