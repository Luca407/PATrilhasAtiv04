using System;

class Program
{
    static void Main()
    {
    	 Console.WriteLine("Você não deseja cancelar a operação? (sim/não)");

        string resposta = Console.ReadLine().ToLower(); // Lê e converte a resposta para minúscula

        if (resposta == "não" || resposta == "n")
        {
            Console.WriteLine("Por favor, confirme o cancelamento da operação.");
        }
        else
        {
            Console.WriteLine("Operação prosseguindo...");
        }
    }
}
