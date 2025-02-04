using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual é o seu nome?");
        string resposta = Console.ReadLine().ToLower(); 

        	
        if (resposta == "wilson" || resposta == "gloria")
        {
            Console.WriteLine("Olá, bem-vindo(a) de volta!");
        }
        else
        {
            Console.WriteLine("Não te conheço.");
        }

        Console.ReadKey();
    }
}
