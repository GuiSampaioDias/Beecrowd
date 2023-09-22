/*
autor: Guilherme Sampaio Dias
exercício: 1096- Sequencia IJ 3
plataforma: Beecrowd
data: 21/09/2023
Linguagem: C#

*/
using System;

public class Sequencia_IJ_3
{
    public static void Main()
    {
        int j = 7;
        int i = 1;
        while (i != 11)
        {
            Console.WriteLine("I=" + i + " J=" + j);
            j -= 1;
            Console.WriteLine("I=" + i + " J=" + j);
            j -= 1;
            Console.WriteLine("I=" + i + " J=" + j);
            i += 2;
            j += 4;
        }
    }
}