/*
autor: Guilherme Sampaio Dias
exercício: 1038 - Lanche
plataforma: Beecrowd
data: 09/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        string entrada = Console.ReadLine();
        string[] valores = entrada.Split(' ');
        double.TryParse(valores[1], out double quantidade);
        double total;

        if (valores[0] == "1")
            total = 4.0 * quantidade;

        else if (valores[0] == "2")
            total = 4.5 * quantidade;

        else if (valores[0] == "3")
            total = 5.0 * quantidade;

        else if (valores[0] == "4")
            total = 2.0 * quantidade;
        else
            total = 1.5 * quantidade;
        string res = total.ToString("f2");
        Console.WriteLine("Total: R$ " + res);
    }
}