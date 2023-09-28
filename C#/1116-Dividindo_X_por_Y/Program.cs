/*
autor: Guilherme Sampaio Dias
exercício: 1116- Dividindo X por Y
plataforma: Beecrowd
data: 25/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');
            double x = double.Parse(valor[0]);
            double y = double.Parse(valor[1]);

            if (y == 0)
                Console.WriteLine("divisao impossivel");

            else
            {
                double resultado = x / y;
                string res_f = resultado.ToString("f1");
                Console.WriteLine(res_f);
            }
        }
    }
}