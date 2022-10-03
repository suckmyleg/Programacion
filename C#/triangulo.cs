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
				for (int i = 0; i < altura; i++)
				{
					for(int a = 0; a < altura-(i+1); a++) Console.Write(" ");
					for(int b = 0; b <= i*2; b++) Console.Write("*");
					Console.Write("\n");
				}
			}
			else Console.WriteLine("La base no puede ser par");
			
		}
		else Console.WriteLine("La base no puede ser menos de 3");		
	}
}
