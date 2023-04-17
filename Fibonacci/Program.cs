using System;

class Program
{
    static void Main(string[] args)
    {
        int valor, x = 0,
            y = 1,
            z = 0;
        bool teste = false;

        Console.Write("Digite um valor inteiro: ");
        valor = int.Parse(Console.ReadLine());

        if (valor == 0 || valor == 1)
        {
            teste = true;
        }
        else
        {
            while (z < valor)
            {
                z = x + y;
                x = y;
                y = z;

                if (z == valor)
                {
                    teste = true;
                    break;
                }
            }
        }

        if (teste)
        {
            Console.WriteLine($"{valor} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{valor} não pertence à sequência de Fibonacci.");
        }

        Console.ReadLine();
    }
}
