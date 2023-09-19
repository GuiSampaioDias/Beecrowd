/*
autor: Guilherme Sampaio Dias
exercício: 1066- Pares Ímpares Positivos e Negativos
plataforma: Beecrowd
data: 18/09/2023
Linguagem: C#

*/
using System;

public class Pares_Impares
{
    public static void Main()
    {
        int par = 0;
        int impar = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i < 5; i++)
        {
            double valor = double.Parse(Console.ReadLine());
            if (valor % 2 == 0)
                par += 1;
            else if (valor % 2 != 0)
                impar += 1;
            if (valor > 0)
                positivo += 1;
            else if (valor < 0)
                negativo += 1;
        }
        Console.WriteLine(par + " valor(es) par(es)");
        Console.WriteLine(impar + " valor(es) impar(es)");
        Console.WriteLine(positivo + " valor(es) positivo(s)");
        Console.WriteLine(negativo + " valor(es) negativo(s)");
    }
}