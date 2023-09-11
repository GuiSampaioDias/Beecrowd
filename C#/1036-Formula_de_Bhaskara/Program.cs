/*
autor: Guilherme Sampaio Dias
exercício: 1036 - Fórmula de Bhaskara
plataforma: Beecrowd
data: 10/09/2023
Linguagem: C#

*/
using System;

class Bhaskara
{
    static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double.TryParse(valor[0], out double A);
        double.TryParse(valor[1], out double B);
        double.TryParse(valor[2], out double C);

        double delta = B * B - 4 * A * C;

        if (2 * A == 0 || delta < 0)
            Console.WriteLine("Impossivel calcular");

        else
        {
            double raiz_delta = Math.Sqrt(delta);
            double r1 = (-B + raiz_delta) / (2 * A);
            double r2 = (-B - raiz_delta) / (2 * A);
            string r1_f = r1.ToString("f5");
            string r2_f = r2.ToString("f5");
            Console.WriteLine("R1 = " + r1_f + "\nR2 = " + r2_f);
        }
    }
}