/*
autor: Guilherme Sampaio Dias
exercício: 1099- Soma Ímpares Consecutivos 2
plataforma: Beecrowd
data: 22/09/2023
Linguaem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantidade; i++)
        {
            int total = 0;
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');
            int val1 = int.Parse(valor[0]);
            int val2 = int.Parse(valor[1]);

            if (val1 == val2)
                Console.WriteLine(0);

            else if (val1 < val2)
            {
                val1 += 1;
                while (val1 <= val2 - 1)
                {
                    if (val1 % 2 == 1)
                        total += val1;
                    val1 += 1;
                }
                Console.WriteLine(total);
            }
            else
            {
                val2 += 1;
                while (val2 <= val1 - 1)
                {
                    if (val2 % 2 == 1)
                        total += val2;
                    val2 += 1;
                }
                Console.WriteLine(total);
            }
        }
    }
}