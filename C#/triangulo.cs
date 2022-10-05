using System;

class Triangulo{
	static void Main(){
		int max_base;
		try{ max_base = Convert.ToInt32(Console.ReadLine());}
		catch(Exception) {Console.WriteLine("La base ha de ser un número entero"); return;}		
		if (max_base >= 3)
		{
			if (max_base%2!=0)
			{
				int altura = (max_base/2)+1;
				for (int y = 0; y < altura; y++)
				{
					for(int x = 0; x<max_base; x++)
					{
						if (x <= (max_base/2)+y && x >= (max_base/2)-y) Console.Write("*");
						else Console.Write(" ");
					}
					Console.Write("\n");
				}
			}
			else Console.WriteLine("La base no puede ser par");
			
		}
		else Console.WriteLine("La base no puede ser menos de 3");		
	}
}
