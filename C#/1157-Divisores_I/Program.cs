/*
autor: Guilherme Sampaio Dias
exercício: 1157- Divisores I
plataforma: Beecrowd
data: 10/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(1);
        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}