using System;

class Program
{
    static void Main()
    {
        int numero = Convert.ToInt32(Console.ReadLine());
		int absoluto = (numero < 0) ? -numero : numero;
		Console.WriteLine("Valor absoluto: " + absoluto);

        Console.ReadKey();
    }
}
