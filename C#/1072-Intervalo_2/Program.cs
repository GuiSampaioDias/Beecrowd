/*
autor: Guilherme Sampaio Dias
exercício: 1072- Intervalo 2 
plataforma: Beecrowd
data: 19/09/2023
Linguagem: C#

*/
using System;

public class Intervalo_2
{
    public static void Main()
    {
        int dentro = 0;
        int fora = 0;
        int val = int.Parse(Console.ReadLine());

        for (int i = 0; i < val; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor >= 10 && valor <= 20)
                dentro += 1;
            else
                fora += 1;
        }
        Console.WriteLine(dentro + " in");
        Console.WriteLine(fora + " out");
    }
}