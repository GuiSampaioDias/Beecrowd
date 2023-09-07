/*
 * CODIGO NÃO FINALIZADO
autor: Guilherme Sampaio Dias
exercício: 1021 - Notas e Moedas
plataforma: Beecrowd
data: 06/09/2023

*/
using System;

public class Notas_e_Moedas
{
    public static void Main()
    {
        double total = double.Parse(Console.ReadLine());
        int cem = (int)(total / 100);
        Console.WriteLine("NOTAS:");
        Console.WriteLine(cem + " nota(s) de R$ 100.00");

        total -= cem * 100;
        int cinq = (int)(total / 50);
        Console.WriteLine(cinq + " nota(s) de R$ 50.00");

        total -= cinq * 50;
        int vinte = (int)(total / 20);
        Console.WriteLine(vinte + " nota(s) de R$ 20.00");

        total -= vinte * 20;
        int dez = (int)(total / 10);
        Console.WriteLine(dez + " nota(s) de R$ 10.00");

        total -= dez * 10;
        int cinco = (int)(total / 5);
        Console.WriteLine(cinco + " nota(s) de R$ 5.00");

        total -= cinco * 5;
        int dois = (int)(total / 2);
        Console.WriteLine(dois + " nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");

        total -= dois * 2;
        int um = (int)(total / 1);
        Console.WriteLine(um + " moeda(s) de R$ 1.00");

        total -= um * 1;
        total = total * 100;

        int m_cinq = (int)(total / 50);
        Console.WriteLine(m_cinq + " moeda(s) de R$ 0.50");

        total -= m_cinq * 50;
        int m_vin = (int)(total / 25);
        Console.WriteLine(m_vin + " moeda(s) de R$ 0.25");

        total -= m_vin * 25;
        int m_dez = (int)(total / 10);
        Console.WriteLine(m_dez + " moeda(s) de R$ 0.10");

        total -= m_dez * 10;
        int m_cinco = (int)(total / 5);
        Console.WriteLine(m_cinco + " moeda(s) de R$ 0.05");

        total -= m_cinco * 5;
        int m_um = (int)(total / 1);
        Console.WriteLine(m_um + " moeda(s) de R$ 0.01");

    }
}