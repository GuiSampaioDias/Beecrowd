/*
autor: Guilherme Sampaio Dias
exercício: 1064- Positivos Média    
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Numeros_Pares
{
    public static void Main()
    {
        int positivos = 0;
        double total = 0;

        for (int i = 0; i < 6; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor > 0)
            {
                positivos += 1;
                total += valor;
            }
        }
        if (positivos > 0)
        {
            double media = total / positivos;
            string media_f = media.ToString("f1");
            Console.WriteLine(positivos + " valores positivos\n" + media_f);
        }
        else
            Console.WriteLine("0 valores positivos\n0");
    }
}