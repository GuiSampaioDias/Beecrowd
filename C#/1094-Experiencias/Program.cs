/*
autor: Guilherme Sampaio Dias
exercício: 1094- Experiências
plataforma: Beecrowd
data: 20/09/2023
Linguagem: C#

*/
using System;

public class Experiencia
{
    public static void Main()
    {
        double cobaias = 0;
        double coelho = 0;
        double rato = 0;
        double sapo = 0;
        double quantidade = 0;

        int variavel = int.Parse(Console.ReadLine());
        for (int i = 0; i < variavel; i++)
        {
            string animais = Console.ReadLine();
            string[] animal = animais.Split(' ');
            double.TryParse(animal[0], out quantidade);
            string tipo = animal[1];

            cobaias += quantidade;

            if (tipo == "C")
                coelho += quantidade;
            else if (tipo == "R")
                rato += quantidade;
            else
                sapo += quantidade;
        }
        // Criar as porcentagens de cada animal
        double cem_coelho = 100 * coelho / cobaias;
        string coelho_f = cem_coelho.ToString("f2");

        double cem_rato = 100 * rato / cobaias;
        string rato_f = cem_rato.ToString("f2");

        double cem_sapo = 100 * sapo / cobaias;
        string sapo_f = cem_sapo.ToString("f2");

        Console.WriteLine("Total: " + cobaias + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelho);
        Console.WriteLine("Total de ratos: " + rato);
        Console.WriteLine("Total de sapos: " + sapo);
        Console.WriteLine("Percentual de coelhos: " + coelho_f + " %");
        Console.WriteLine("Percentual de ratos: " + rato_f + " %");
        Console.WriteLine("Percentual de sapos: " + sapo_f + " %");
    }
}