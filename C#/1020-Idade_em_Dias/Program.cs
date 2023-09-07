/*
autor: Guilherme Sampaio Dias
exercício: 1020 - Idade em Dias
plataforma: Beecrowd
data: 05/09/2023

*/
using System;

class Idade_em_Dias
{
    static void Main()
    {
        int dias = int.Parse(Console.ReadLine());
        int anos = dias / 365;
        Console.WriteLine(anos + " ano(s)");

        int anos_em_dias = anos * 365;
        int mes = (dias - anos_em_dias) / 30;
        Console.WriteLine(mes + " mes(es)");

        int meses_em_dias = mes * 30;
        dias = dias - (anos_em_dias + meses_em_dias);
        Console.WriteLine(dias + " dia(s)");
    }
}