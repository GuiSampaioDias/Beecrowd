/*
autor: Guilherme Sampaio Dias
exercício: 1044- Múltiplos
plataforma: Beecrowd
data: 12/09/2023
Linguagem: C#

*/
using System;

public class Multiplos
{
    public static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        int.TryParse(valor[0], out int A);
        int.TryParse(valor[1], out int B);

        if (A % B == 0 || B % A == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");
    }
}