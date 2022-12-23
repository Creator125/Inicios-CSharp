//Operadores arimetticos
using System;

namespace Opreradores_arimeticos
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num1 = 15;
			int num2 = 5;
			
			Console.WriteLine("La suma de "+num1+" + "+num2+" Es igual a "+ (num1 + num2));
			
			Console.WriteLine("La resta de "+num1+" - "+num2+" Es igual a "+ (num1 - num2));
		
			Console.WriteLine("La multiplicación de "+num1+" * "+num2+" Es igual a "+ (num1 * num2));
			
			Console.WriteLine("La división de "+num1+" / "+num2+" Es igual a "+ (num1 / num2));
			
			Console.WriteLine("El residuo de "+num1+" % "+num2+" Es igual a "+ (num1 % num2));
			
			Console.ReadKey(true);
		}
	}
}