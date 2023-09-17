/*
autor: Guilherme Sampaio Dias
exercício: 1048- Aumento de Salário
plataforma: Beecrowd
data: 13/09/2023
Linguagem: C#

*/
using System;

public class Tempo_de_jogo
{
    public static void Main()
    {
        double salario = double.Parse(Console.ReadLine());
        string salario_f = "";
        string diferenca_f = "";
        string por_cem = "15 %";

        if (salario <= 400)
        {
            double n_salario = salario * 15 / 100 + salario;
            salario_f = n_salario.ToString("f2");
            double diferenca = n_salario - salario;
            diferenca_f = diferenca.ToString("f2");

        }
        else if (salario <= 800)
        {
            double n_salario = salario * 12 / 100 + salario;
            salario_f = n_salario.ToString("f2");
            double diferenca = n_salario - salario;
            diferenca_f = diferenca.ToString("f2");
            por_cem = "12 %";
        }
        else if (salario <= 1200)
        {
            double n_salario = salario * 10 / 100 + salario;
            salario_f = n_salario.ToString("f2");
            double diferenca = n_salario - salario;
            diferenca_f = diferenca.ToString("f2");
            por_cem = "10 %";
        }
        else if (salario <= 2000)
        {
            double n_salario = salario * 7 / 100 + salario;
            salario_f = n_salario.ToString("f2");
            double diferenca = n_salario - salario;
            diferenca_f = diferenca.ToString("f2");
            por_cem = "7 %";
        }
        else
        {
            double n_salario = salario * 4 / 100 + salario;
            salario_f = n_salario.ToString("f2");
            double diferenca = n_salario - salario;
            diferenca_f = diferenca.ToString("f2");
            por_cem = "4 %";
        }
        Console.WriteLine("Novo salario: " + salario_f + "\nReajuste ganho: " + diferenca_f + "\nEm percentual: " + por_cem);
    }
}
