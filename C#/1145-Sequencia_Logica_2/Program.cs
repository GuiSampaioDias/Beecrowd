/*
autor: Guilherme Sampaio Dias
exercício: 1145- Sequencia Lógica 2
plataforma: Beecrowd
data: 30/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double valor1 = double.Parse(valor[0]);
        double valor2 = double.Parse(valor[1]);
        int x = 1;
        while (x < valor2 - 1)
        {
            if (valor1 > 1)
            {
                for (int i = 0; i < valor1 - 1; i++)
                {
                    if (x == valor2 - 1)
                    {
                        Console.Write(x);
                        Console.Write(' ');
                        break;
                    }
                    Console.Write(x);
                    Console.Write(' ');
                    x += 1;
                }
            }
            if (x == valor2 - 1)
            {
                x += 1;
                break;
            }
            Console.WriteLine(x);
            x += 1;
        }

        Console.WriteLine(x);
    }
}