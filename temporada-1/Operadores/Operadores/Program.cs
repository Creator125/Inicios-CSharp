//Tema: Operadores
using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num= 0, num1 = 5, num2 = 7, num3;

            int varnegativo = -num1;
            Console.WriteLine("Valor negativo de num1: {0}",varnegativo);

            //Operadores de adición
            num++;
            Console.WriteLine("num es: {0}",num);
            Console.WriteLine("num es: {0}", num++);
            Console.WriteLine("num es: {0}", num);

            //Operadores de sustración
            num--;
            Console.WriteLine("num es: {0}", num);
            Console.WriteLine("num es: {0}", --num);
            Console.WriteLine("num es: {0}", num);

            //Operadores matematicos
            int suma = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " = " + suma);
            int resta = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " = " + resta);
            int multiplicacion = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " = " + multiplicacion);
            int division = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " = " + division);
            int modulo = num1 % num2;//Oprador modular
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " = " + modulo);

            //Booleanos
            bool estoyProgamandoEn = true;
            Console.WriteLine("¿Estoy progamndo en Java?: {0}", !estoyProgamandoEn);

            //Opradores relacionales
            bool expresion;
            expresion = num1 < num2; //Menor
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " = " + expresion);
            expresion = num1 == num2; //Igualdad
            Console.WriteLine("El resultado de " + num1 + " == " + num2 + " = " + expresion);
            expresion = num1 != num2; //Diferencia
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " = " + expresion);

            //Operadores condicionales
            bool evaluador;
            evaluador = expresion && estoyProgamandoEn; //Operador Y
            Console.WriteLine("El resultado de " + expresion + " && " + estoyProgamandoEn + " = " + evaluador);
            evaluador = expresion || estoyProgamandoEn; //Operador O
            Console.WriteLine("El resultado de " + expresion + " || " + estoyProgamandoEn + " = " + evaluador);

            Console.Read();
        }
    }
}
