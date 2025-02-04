using System;

class Program
{
    static void Main()
    {
        string texto = Console.ReadLine();
	string resultado = (string.IsNullOrEmpty(texto)) ? "String vazia" : "String não vazia";
	Console.WriteLine(resultado);

        Console.ReadKey();
    }
}
