using System;

class Program
{
    static void Main()
    {
    	Console.WriteLine("Digite um número:");
    	int x = Convert.ToInt32(Console.ReadLine());
    	Console.WriteLine("Digite outro número:");
    	int y = Convert.ToInt32(Console.ReadLine());
    	
    	int maior = (x > y) ? x : y;

	Console.WriteLine("O maior número é " + maior);
	Console.ReadKey();
     }
 }
