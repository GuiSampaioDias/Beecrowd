/*
autor: Guilherme Sampaio Dias
exercício: 1041- Coordenadas de um ponto
plataforma: Beecrowd
data: 11/09/2023
Linguagem: C#

*/
using System;

public class Coordenadas_de_um_ponto
{
    public static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double.TryParse(valor[0], out double x);
        double.TryParse(valor[1], out double y);

        if (x == 0 && y == 0)
            Console.WriteLine("Origem");

        else if (x == 0)
            Console.WriteLine("Eixo Y");

        else if (y == 0)
            Console.WriteLine("Eixo X");

        else if (x > 0 && y > 0)
            Console.WriteLine("Q1");

        else if (x < 0 && y > 0)
            Console.WriteLine("Q2");

        else if (x < 0 && y < 0)
            Console.WriteLine("Q3");

        else
            Console.WriteLine("Q4");
    }
}