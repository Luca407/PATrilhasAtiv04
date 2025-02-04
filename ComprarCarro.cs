using System;

class Program
{
    static void Main()
    {
    	string resposta;
        do
        {
            Console.WriteLine("Você gostaria de comprar um carro? (sim/não) ");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "não")
            {
                Console.WriteLine("Resposta inválida. Digite apenas 'sim' ou 'não'.");
            }

        } while (resposta != "sim" && resposta != "não");
        
        if (resposta == "sim")
        {
        	Console.WriteLine("Você tem o dinheiro necessário? ");
        	resposta = Console.ReadLine();
        	
   		     if (resposta == "sim")
            {
                
                Console.WriteLine("Parabéns, você pode comprar um carro novo!");
            }
            else
            {
                
                Console.WriteLine("Infelizmente, você não pode comprar um carro novo.");
            }
        }
        else
        {
            
            Console.WriteLine("Ok, talvez outra hora!");
        }
        Console.ReadKey(true);
    }
}
