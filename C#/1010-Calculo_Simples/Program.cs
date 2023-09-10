/*
autor: Guilherme Sampaio Dias
exercício: 1010 - Cálculo Simples
plataforma: Beecrowd
data: 09/09/2023
Linguagem: C#

*/
using System;

class CalculoSimples
{
    static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double.TryParse(valor[1], out double quant1);
        double.TryParse(valor[2], out double valor1);

        string segundo = Console.ReadLine();
        string[] val = segundo.Split(' ');
        double.TryParse(val[1], out double quant2);
        double.TryParse(val[2], out double valor2);

        double total = quant1 * valor1 + quant2 * valor2;
        string total_f = total.ToString("f2");
        Console.WriteLine("VALOR A PAGAR: R$ " + total_f);


    }
}