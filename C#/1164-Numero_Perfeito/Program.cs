/*
autor: Guilherme Sampaio Dias
exercício: 1164- Número Perfeito
plataforma: Beecrowd
data: 12/10/2023
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
            int num = int.Parse(Console.ReadLine());
            int copy_num = (int)num / 2,
                perfect = 0;
            for (int n = 1; n <= copy_num; n++)
            {
                if (num % n == 0)
                    perfect += n;
            }
            if (perfect == num)
                Console.WriteLine(num.ToString() + " eh perfeito");
            else
                Console.WriteLine(num.ToString() + " nao eh perfeito");
        }
    }
}