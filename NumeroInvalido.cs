using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual é o seu nome?");
        int x = Convert.ToInt32(Console.ReadLine());

        	
        if (x > 10 || x < 0)
        {
            Console.WriteLine("Número inválido!");
        }
        else
        {
            Console.WriteLine("Número válido.");
        }

        Console.ReadKey();
    }
}
