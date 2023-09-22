/*
autor: Guilherme Sampaio Dias
exercício: 1096- Sequencia IJ 2
plataforma: Beecrowd
data: 21/09/2023
Linguagem: C#

*/
using System;

public class Sequencia_IJ_2
{
    public static void Main()
    {

        int i = 1;
        while (i != 11)
        {
            int j = 7;
            Console.WriteLine("I=" + i + " J=" + j);
            j -= 1;
            Console.WriteLine("I=" + i + " J=" + j);
            j -= 1;
            Console.WriteLine("I=" + i + " J=" + j);
            i += 2;
        }
    }
}