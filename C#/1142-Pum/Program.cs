/*
autor: Guilherme Sampaio Dias
exercício: 1142- Pum
plataforma: Beecrowd
data: 27/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int valor = int.Parse(Console.ReadLine());
        int total = 1;
        for (int i = 0; i < valor; i++)
        {
            for (int n = 0; n < 3; n++)
            {
                Console.Write(total + " ");
                total += 1;
            }
            Console.WriteLine("PUM");
            total += 1;
        }
    }
}