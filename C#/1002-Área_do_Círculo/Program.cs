/*
 autor: Guilherme Sampaio Dias
 exercício: 1001 Extremamente Básico
 plataforma: Beecrowd
 
 */
using System;

class Program
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double p = 3.14159;
        double quadrado = Math.Pow(r, 2);

        double res = p * quadrado;
        string res_formatado = res.ToString("f4");

        Console.WriteLine("A=" + res_formatado);  

    }
}