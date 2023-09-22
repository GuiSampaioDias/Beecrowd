/*
autor: Guilherme Sampaio Dias
exercício: 1074- Par ou Ímpar 
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Par_ou_Impar
{
    public static void Main()
    {
        string pos_neg = "";
        string par_impar = "";
        int numeros = int.Parse(Console.ReadLine());
        for (int i = 0; i < numeros; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            if (valor == 0)
                Console.WriteLine("NULL");
            else
            {
                if (valor > 0)
                    pos_neg = "POSITIVE";
                else
                    pos_neg = "NEGATIVE";
                if (valor % 2 != 0)
                    par_impar = "ODD ";
                else
                    par_impar = "EVEN ";

                Console.WriteLine(par_impar + pos_neg);
            }
        }
    }
}