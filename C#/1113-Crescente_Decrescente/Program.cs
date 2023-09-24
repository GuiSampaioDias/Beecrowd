/*
autor: Guilherme Sampaio Dias
exercício: 1113- Crescente Decrescente
plataforma: Beecrowd
data: 23/09/2023
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
            if (val1 == val2)
                break;
            else if (val1 < val2)
                Console.WriteLine("Crescente");
            else
                Console.WriteLine("Decrescente");
        }
    }
}