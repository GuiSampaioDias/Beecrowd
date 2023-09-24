/*
autor: Guilherme Sampaio Dias
exercício: 1098- Sequencia IJ 4
plataforma: Beecrowd
data: 21/09/2023
Linguagem: C#

*/
using System;

public class Sequencia_IJ_4
{
    public static void Main()
    {
        double j = 1;
        double k = 2;
        double l = 3;
        double i = 0;
        while (i < 2.2)
        {

            Console.WriteLine("I=" + i + " J=" + j);
            j += 0.2;
            Console.WriteLine("I=" + i + " J=" + k);
            k += 0.2;
            Console.WriteLine("I=" + i + " J=" + l);
            i += 0.2;
            l += 0.2;
            if (i % 1 != 0)
                i = Math.Round(i, 1);
            if (j % 1 != 0)
                j = Math.Round(j, 1);
            if (k % 1 != 0)
                k = Math.Round(k, 1);
            if (l % 1 != 0)
                l = Math.Round(l, 1);
        }
    }
}