using System;

class Program
{
    static void Main()
    {
        string resposta;
        do
        {
            Console.WriteLine("Você gostaria de tomar um café? (sim/não) ");
            resposta = Console.ReadLine().ToLower();

            if (resposta != "sim" && resposta != "não")
            {
                Console.WriteLine("Resposta inválida. Digite apenas 'sim' ou 'não'.");
            }

        } while (resposta != "sim" && resposta != "não");

        if (resposta == "sim")
        {
            do
            {
                Console.WriteLine("Você gostaria de tomar com leite, açúcar ou puro? (leite/açúcar/não)");
                resposta = Console.ReadLine().ToLower();

                if (resposta != "leite" && resposta != "açúcar" && resposta != "não")
                {
                    Console.WriteLine("Resposta inválida. Digite apenas 'leite', 'açúcar' ou 'não'.");
                }

            } while (resposta != "leite" && resposta != "açúcar" && resposta != "não");

            // Exibir mensagem final com base na escolha
            if (resposta == "leite")
                Console.WriteLine("Café com adicional de leite, está feito. Aproveite!");

            else if (resposta == "açúcar")
                Console.WriteLine("Café com adicional de açúcar, está feito. Aproveite!");

            else
                Console.WriteLine("Café puro, está feito. Aproveite!");
        }
        else
        {
            Console.WriteLine("Tudo bem, tenha um bom dia!");
        }

        Console.ReadKey();
    }
}
