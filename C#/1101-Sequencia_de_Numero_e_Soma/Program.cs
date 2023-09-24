/*
autor: Guilherme Sampaio Dias
exercício: 1101- Sequência de Números e Soma 
plataforma: Beecrowd
data: 22/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            int total = 0;
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');
            int val1 = int.Parse(valor[0]);
            int val2 = int.Parse(valor[1]);
            if (val1 <= 0 || val2 <= 0)
                break;

            if (val1 <= val2)
            {
                while (val1 <= val2)
                {
                    total += val1;
                    Console.Write(val1 + " ");
                    val1 += 1;

                }
                Console.WriteLine("Sum=" + total);
            }
            else
            {
                while (val2 <= val1)
                {
                    total += val2;
                    Console.Write(val2 + " ");
                    val2 += 1;
                }
                Console.WriteLine("Sum=" + total);
            }
        }
    }
}