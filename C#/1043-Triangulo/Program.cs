/*
autor: Guilherme Sampaio Dias
exercício: 1043- Triângulo
plataforma: Beecrowd
data: 12/09/2023
Linguagem: C#

*/
using System;

public class Triangulo
{
    public static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double.TryParse(valor[0], out double A);
        double.TryParse(valor[1], out double B);
        double.TryParse(valor[2], out double C);

        if (A + B > C && A + C > B && B + C > A)
        {
            double perimetro = A + B + C;
            string perimetro_f = perimetro.ToString("f1");
            Console.WriteLine("Perimetro = " + perimetro_f);
        }
        else
        {
            double area = (A + B) * C / 2;
            string area_f = area.ToString("f1");
            Console.WriteLine("Area = " + area_f);
        }

    }
}