using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual sua idade? ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 21)
        {
            Console.WriteLine("Você não está qualificado.");
            Console.ReadKey(true);
            return; 
        }
        

        string resposta;
        do
        {
            Console.WriteLine("Você possui um diploma de ensino superior? (sim/não) ");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "não")
            {
                Console.WriteLine("Resposta inválida. Digite apenas 'sim' ou 'não'.");
            }

        } while (resposta != "sim" && resposta != "não");

        if (resposta == "sim")
        {
            Console.WriteLine("Parabéns, você está qualificado para a vaga!");
        }
        else
        {
            Console.WriteLine("Você não está qualificado.");
        }
        Console.ReadKey(true);
  	  }
	}

