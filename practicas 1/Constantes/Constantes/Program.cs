//Constantes
using System;

namespace Constantes
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double edad = 20;
			
			const string nombre = "Creator125";
			
			/*
			 Valor que no se puede cambiar por constante
			nombre = "Yecote";
			
			*/
			
			Console.WriteLine("Tu nombre es: "+ nombre + " y tu edad es "+ edad);
			
			Console.ReadKey(true);
		}
	}
}