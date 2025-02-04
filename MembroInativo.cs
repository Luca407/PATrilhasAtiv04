using System;

class Program
{
    static void Main()
    {
         string resposta;
    	 
        do
        {
            Console.WriteLine("Você é um membro ativo do clube? (sim/s/não/n)");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n")
            {
                Console.WriteLine("Entrada inválida! Digite apenas 'sim', 's', 'não' ou 'n'.");
            }

        } while (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n");
        	
        if (resposta == "não" || resposta == "n")
        {	
            Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube");
        }
        else
        {
            Console.WriteLine("Ótimo! Seja bem-vindo.");
        }

        Console.ReadKey();
    }
}
