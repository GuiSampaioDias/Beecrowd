/*
autor: Guilherme Sampaio Dias
exercício: 1158 Soma Ímpares Consecutivos III
plataforma: Beecrowd
data: 10/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
        {
            int tot = 0;
            string values = Console.ReadLine();
            string[] val = values.Split(' ');
            int value1 = int.Parse(val[0]);
            if (value1 % 2 == 0)
                value1 += 1;
            int value2 = int.Parse(val[1]);
            for (int n = 0; n < value2; n++)
            {
                tot += value1;
                value1 += 2;
            }
            Console.WriteLine(tot);

        }
    }
}