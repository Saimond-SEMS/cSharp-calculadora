using System;

namespace itla2calculadora
{
	class MainClass
	{
		public static void pedirNumeros(out int _n1, out int _n2)
		{
			Console.WriteLine("ingrese primer número:");
			_n1 = int.Parse(Console.ReadLine());
			Console.WriteLine("ingrese segundo número:");
			_n2 = int.Parse(Console.ReadLine());
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido!");
			
			while (true)
			{
				Console.WriteLine("------------------------------------------");
				Console.WriteLine("------------------------------------------");
				Console.WriteLine("1 - Sumar      \t 2 - restar");
				Console.WriteLine("3 - Multiplicar\t 4 - dividir");
				Console.WriteLine("5 - Exponente  \t 6 - salir del programa");


				int n1, n2;
				double resultado;
				short operacion = short.Parse(Console.ReadLine());

				switch (operacion)
				{
					case 1:
						pedirNumeros(out n1, out n2);			
						resultado = n1 + n2;
						Console.WriteLine("el resultado es: " + resultado);
						break;

					case 2:
						pedirNumeros(out n1, out n2);

						resultado = n1 - n2;
						Console.WriteLine("el resultado es: " + resultado);
						break;

					case 3:
						pedirNumeros(out n1, out n2);
						resultado = n1 * n2;
						Console.WriteLine("el resultado es: " + resultado);
						break;

					case 4:
						pedirNumeros(out n1, out n2);
						resultado = n1 / n2;
						Console.WriteLine("el resultado es: " + resultado);
						break;

					case 5:
						pedirNumeros(out n1, out n2);
						resultado = Math.Pow(n1, n2);
						Console.WriteLine("el resultado es: " + resultado);
						break;
						
					case 6:
						return;
						
					default:
						Console.WriteLine("Operacion no valida");
						break;
				}
			}
		}
	}
}
