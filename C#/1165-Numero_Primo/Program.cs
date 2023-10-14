/*
autor: Guilherme Sampaio Dias
exercício: 1165- Número Primo
plataforma: Beecrowd
data: 12/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
        {
            int valor = int.Parse(Console.ReadLine());
            int copy_valor = (int)valor / 2;
            string primo = " eh primo";

            if (valor == 1)
                Console.WriteLine("1 nao eh primo");
            else if (valor == 4)
                Console.WriteLine("4 nao eh primo");
            else
            {
                for (int n = 2; n < copy_valor; n++)
                {
                    if (valor % n == 0)
                    {
                        primo = " nao eh primo";
                    }
                }
                Console.WriteLine(valor.ToString() + primo);
            }
        }
    }
}