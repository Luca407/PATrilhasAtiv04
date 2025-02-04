using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual sua idade? ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você não pode dirigir.");
            Console.ReadKey(true);
            return; 
        }
        

        string resposta;
        do
        {
            Console.WriteLine("Você possui carteira de motorista? (sim/não) ");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "não")
            {
                Console.WriteLine("Resposta inválida. Digite apenas 'sim' ou 'não'.");
            }

        } while (resposta != "sim" && resposta != "não");

        if (resposta == "sim")
        {
            Console.WriteLine("Você pode dirigir.");
        }
        else
        {
            Console.WriteLine("Você não pode dirigir.");
        }
        Console.ReadKey(true);
    }
}

