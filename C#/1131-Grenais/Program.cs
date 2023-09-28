/*
autor: Guilherme Sampaio Dias
exercício: 1131- Grenais
plataforma: Beecrowd
data: 2709/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int grenais = 0;
        int inter = 0;
        int gremio = 0;
        int empate = 0;
        while (true)
        {
            string valores = Console.ReadLine();
            string[] valor = valores.Split(' ');
            int inter_gol = int.Parse(valor[0]);
            int gremio_gol = int.Parse(valor[1]);

            if (inter_gol > gremio_gol)
                inter += 1;

            else if (inter_gol < gremio_gol)
                gremio += 1;

            else
                empate += 1;
            grenais += 1;
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int grenal = int.Parse(Console.ReadLine());

            if (grenal == 2)
                break;
        }
        Console.WriteLine(grenais + " grenais");
        Console.WriteLine("Inter:" + inter);
        Console.WriteLine("Gremio:" + gremio);
        Console.WriteLine("Empates:" + empate);

        if (inter > gremio)
            Console.WriteLine("Inter venceu mais");
        else if (inter < gremio)
            Console.WriteLine("Gremio venceu mais");
        else
            Console.WriteLine("Nao houve vencedor");
    }
}