/*
 * 
 autor: Guilherme Sampaio Dias
 exercício: 1008 - Salário
 plataforma: Beecrowd
 data: 04/09/2023

 */
using System;

class Program
{
    static void Main()
    {
        int numero_func = int.Parse(Console.ReadLine());
        int numero_horas = int.Parse(Console.ReadLine());
        double valor_hora = double.Parse(Console.ReadLine());

        double salario = numero_horas * valor_hora;

        string salario_formatado = salario.ToString("f2");
        Console.WriteLine("NUMBER = " + numero_func);
        Console.WriteLine("SALARY = U$ " + salario_formatado);

    }
}