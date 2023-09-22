/*
autor: Guilherme Sampaio Dias
exercício: 1095- Sequencia IJ 1
plataforma: Beecrowd
data: 21/09/2023
Linguagem: C#

*/
using System;

public class Sequencia_IJ
{
    public static void Main()
    {
        int j = 65;
        int i = -2;
        while (j != 0)
        {
            i += 3;
            j -= 5;
            Console.WriteLine("I=" + i + " J=" + j);
        }
    }
}