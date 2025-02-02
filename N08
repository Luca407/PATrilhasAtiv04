using System;

class Program
{
    static void Main()
    {
    	 string resposta;
    	 
        do
        {
            Console.WriteLine("Você deseja comprar este produto? (sim/s/não/n)");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n")
            {
                Console.WriteLine("Entrada inválida! Digite apenas 'sim' ou 's'.");
            }

        } while (resposta != "sim" && resposta != "s" && resposta != "não" && resposta != "n");

        if (resposta == "sim" || resposta == "s"){
        	Console.WriteLine("Obrigado pela compra!");
        }else {
        		Console.WriteLine("Compra não realizada.");
        	}
        	
    	Console.ReadKey();
    } 
    
}
