using System;

class Program
{
    static void Main(string[] args)
    {
        string palavra, inversa = "";

        Console.Write("Digite algo e retornaremos invertido: ");
        palavra = Console.ReadLine();

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            inversa += palavra[i];
        }

        Console.WriteLine($"Palavra invertida: {inversa}");

        Console.ReadLine();
    }
}
