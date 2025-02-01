using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;

        while (true)
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            // Verifica se o nome tem mais de 3 caracteres
            if (nome.Length <= 3)
            {
                Console.WriteLine("Acesso negado. O nome deve ter mais de 3 caracteres.");
                continue; // Repete a solicitação do nome
            }

            Console.Write("Digite sua idade: ");
            // Verifica se a entrada de idade é um número válido
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Idade inválida. Digite um número válido: ");
            }

            
            if (idade >= 18)
            {
                Console.WriteLine("Acesso permitido");
                break; // Finaliza o programa se tudo estiver correto
            }
            else
            {
                Console.WriteLine("Acesso negado. Você deve ter 18 anos ou mais.");
                continue; // Repete a solicitação da idade
            }
        }

        Console.ReadKey();
    }
}
