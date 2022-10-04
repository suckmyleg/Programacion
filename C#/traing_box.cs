using System;

class Caja_trian{
	static void Main()
	{
		int filas = 0;
		
		try{
			Console.Write("Introduce un número de filas entre el rango 9-26 y par: ");
			filas = Convert.ToInt32(Console.ReadLine());
		}
		catch(Exception){ Console.WriteLine("Error, escribe solo números enteros");}
		finally{
			if (filas < 9 || filas > 26) Console.WriteLine("Número de filas incorrecto");
			else
			{
				if (filas%2==0) Console.WriteLine("El número de filas ha de ser impar");
				else
				{
						
					for(int y = 0; y < filas; y++)
					{
						for(int x = 0; x < filas; x++)
						{
							if (y == 0 || y == filas-1 || x == 0 || x == filas-1 || x == y || x+y == filas-1) Console.Write("*");
							else Console.Write(" ");
						}
						Console.Write("\n");
					}
				}
			}
		}
	}
}
