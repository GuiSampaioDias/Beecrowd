/*
 * 
 autor: Guilherme Sampaio Dias
 exercício: 1011 - Esfera
 plataforma: Beecrowd
 data: 04/09/2023

 */
using System;

class Program
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        double cubo = Math.Pow(r, 3);
        double volume =  4.0 / 3.0 * 3.14159 * cubo;
        string volume_f = volume.ToString("f3");
        Console.WriteLine("VOLUME = " + volume_f);
    }
}
