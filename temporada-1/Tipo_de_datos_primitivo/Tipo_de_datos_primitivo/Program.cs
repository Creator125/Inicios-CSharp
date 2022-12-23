//Tipo de datos primitivos
using System;

namespace Tipo_de_datos_primitivo
{
	class Program
	{
		public static void Main(string[] args)
		{

			int entero = 19;
			double decimal_grande = 10.55;
			string cadena ="Creator125";
			bool CSharp_es_divertido = true;
			
			
			Console.WriteLine("Dato de tipo entero : " + entero);
			Console.WriteLine("Dato de tipo decimal con más capacidad: " + decimal_grande);
			Console.WriteLine("Dato de tipo cadena: " + cadena);
			Console.WriteLine("Tipo de dato booleano (CSharp_es_divertido): " + CSharp_es_divertido);
		
			Console.ReadKey(true);
		}
	}
}