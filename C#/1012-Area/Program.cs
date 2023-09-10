/*
autor: Guilherme Sampaio Dias
exercício: 1012 - Área
plataforma: Beecrowd
data: 09/09/2023
Linguagem: C#

*/
using System;

class Area
{
    static void Main()
    {
        string valores = Console.ReadLine();
        string[] valor = valores.Split(' ');
        double.TryParse(valor[0], out double A);
        double.TryParse(valor[1], out double B);
        double.TryParse(valor[2], out double C);

        double triangulo = A * C / 2;
        string tri = triangulo.ToString("f3");

        double circulo = C * C * 3.14159;
        string cir = circulo.ToString("f3");

        double trapezio = (A + B) * C / 2.0;
        string tra = trapezio.ToString("f3");

        double quadrado = B * B;
        string qua = quadrado.ToString("f3");

        double retangulo = A * B;
        string ret = retangulo.ToString("f3");

        Console.WriteLine("TRIANGULO: " + tri);
        Console.WriteLine("CIRCULO: " + cir);
        Console.WriteLine("TRAPEZIO: " + tra);
        Console.WriteLine("QUADRADO: " + qua);
        Console.WriteLine("RETANGULO: " + ret);

    }
}