﻿/*
autor: Guilherme Sampaio Dias
exercício: 1052- Mês     
plataforma: Beecrowd
data: 15/09/2023
Linguagem: C#

*/
using System;

public class Mes
{
    public static void Main()
    {
        int mes = int.Parse(Console.ReadLine());

        if (mes == 1)
            Console.WriteLine("January");
        else if (mes == 2)
            Console.WriteLine("February");
        else if (mes == 3)
            Console.WriteLine("March");
        else if (mes == 4)
            Console.WriteLine("April");
        else if (mes == 5)
            Console.WriteLine("May");
        else if (mes == 6)
            Console.WriteLine("June");
        else if (mes == 7)
            Console.WriteLine("July");
        else if (mes == 8)
            Console.WriteLine("August");
        else if (mes == 9)
            Console.WriteLine("September");
        else if (mes == 10)
            Console.WriteLine("October");
        else if (mes == 11)
            Console.WriteLine("November");
        else
            Console.WriteLine("December");
    }
}
