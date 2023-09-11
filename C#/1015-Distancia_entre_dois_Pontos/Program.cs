/*
autor: Guilherme Sampaio Dias
exercício: 1015 - Distância Entre Dois Pontos
plataforma: Beecrowd
data: 10/09/2023
Linguagem: C#

*/
using System;

class Distancia_etre_dois_Pontos
{
    static void Main()
    {
        string pri_ponto = Console.ReadLine();
        string[] primeiro = pri_ponto.Split(' ');
        double.TryParse(primeiro[0], out double x1);
        double.TryParse(primeiro[1], out double y1);

        string seg_ponto = Console.ReadLine();
        string[] segundo = seg_ponto.Split(' ');
        double.TryParse(segundo[0], out double x2);
        double.TryParse(segundo[1], out double y2);

        double x = x2 - x1;
        double x_quadrado = Math.Pow(x, 2);

        double y = y2 - y1;
        double y_quadrado = Math.Pow(y, 2);

        double soma = x_quadrado + y_quadrado;

        double distancia = Math.Sqrt(soma);
        string dist_f = distancia.ToString("f4");
        Console.WriteLine(dist_f);

    }
}