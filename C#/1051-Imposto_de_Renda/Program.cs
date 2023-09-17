/*
autor: Guilherme Sampaio Dias
exercício: 1051- Imposto de Renda     
plataforma: Beecrowd
data: 15/09/2023
Linguagem: C#

*/
using System;

public class Imposto_de_Renda
{
    public static void Main()
    {
        double valor = double.Parse(Console.ReadLine());
        string valor_f = "Isento";
        double dois = (3000.00 - 2000.01) * 8 / 100;
        double tres = (4500.00 - 3000.00) * 18 / 100;
        if (valor <= 2000.00)
        {
            Console.WriteLine(valor_f);

        }
        else if (valor <= 3000.00)
        {
            valor = (valor - 2000.00) * 8 / 100;
            valor_f = valor.ToString("f2");
            Console.WriteLine("R$ " + valor_f);
        }
        else if (valor <= 4500)
        {
            valor = (valor - 3000.00) * 18 / 100 + dois;
            valor_f = valor.ToString("f2");
            Console.WriteLine("R$ " + valor_f);
        }
        else
        {
            valor = (valor - 4500.00) * 28 / 100 + dois + tres;
            valor_f = valor.ToString("f2");
            Console.WriteLine("R$ " + valor_f);
        }
    }
}
