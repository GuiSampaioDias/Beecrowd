/*
autor: Guilherme Sampaio Dias
exercício: 1035 - Cédulas
plataforma: Beecrowd
data: 06/09/2023

*/
using System;

class Teste_de_Selecao_1
{
    static void Main()
    {
        string valores = Console.ReadLine();
        string[] lista = valores.Split(' ');

        int.TryParse(lista[0], out int A);
        int.TryParse(lista[1], out int B);
        int.TryParse(lista[2], out int C);
        int.TryParse(lista[3], out int D);

        if (B > C && D > A && (C + D) > (A + B) && C >= 0 && D >= 0 && A % 2 == 0)

            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");

    }
}
