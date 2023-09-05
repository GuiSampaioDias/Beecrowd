/*
 * 
 autor: Guilherme Sampaio Dias
 exercício: 1009 - Salário com Bônus
 plataforma: Beecrowd
 data: 04/09/2023

 */
using System;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        double comissao = vendas * 15 / 100;
        double total = salario + comissao;
        string total_formatado = total.ToString("f2");
        Console.WriteLine("TOTAL = R$ " + total_formatado);
    }
}