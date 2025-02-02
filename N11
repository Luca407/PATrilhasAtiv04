using System;

class Program
{
    static void Main()
    {
         string resposta;
    	 
        do
        {
            Console.WriteLine("Você é um robô? (sim/s/não/n)");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n")
            {
                Console.WriteLine("Entrada inválida! Digite apenas 'sim', 's', 'não' ou 'n'.");
            }

        } while (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n");
        	
        if (resposta == "não" || resposta == "n")
        {
            Console.WriteLine("Por favor, prove que você não é um robô.");
        }
        else
        {
            Console.WriteLine("Ótimo! Seja bem-vindo.");
        }

        Console.ReadKey();
    }
}
