/*
autor: Guilherme Sampaio Dias
exercício: 1115- Quadrante
plataforma: Beecrowd
data: 25/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');
            int val1 = int.Parse(valor[0]);
            int val2 = int.Parse(valor[1]);

            if (val1 == 0 || val2 == 0)
                break;

            else if (val1 > 0 && val2 > 0)
                Console.WriteLine("primeiro");

            else if (val1 > 0 && val2 < 0)
                Console.WriteLine("quarto");

            else if (val1 < 0 && val2 < 0)
                Console.WriteLine("terceiro");

            else
                Console.WriteLine("segundo");

        }
    }
}