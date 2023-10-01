/*
autor: Guilherme Sampaio Dias
exercício: 1151- Fibonacci fácil  
plataforma: Beecrowd
data: 01/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int val1 = 0;
        int val2 = 1;
        int copy = val2;

        int valor = int.Parse(Console.ReadLine());

        if (valor == 1)
            Console.WriteLine(0);

        else if (valor == 2)
            Console.WriteLine("0 1");

        else
        {
            Console.Write("0 1 ");
            for (int i = 0; i < valor - 3; i++)
            {
                Console.Write(val1 + val2);
                Console.Write(' ');
                copy = val1 + val2;
                val1 = val2;
                val2 = copy;

            }
            Console.WriteLine(val1 + val2);
        }

    }
}