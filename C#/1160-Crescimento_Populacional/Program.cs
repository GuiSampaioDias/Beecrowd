/*
autor: Guilherme Sampaio Dias
exercício: 1160- Crescimento Populacional
plataforma: Beecrowd
data: 12/10/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int testes = int.Parse(Console.ReadLine());
        for (int i = 0; i < testes; i++)
        {
            string total_paises = Console.ReadLine();
            string[] paises = total_paises.Split(' ');
            double pais1 = double.Parse(paises[0]);
            double pais2 = double.Parse(paises[1]);
            double cresci1 = double.Parse(paises[2]);
            double cresci2 = double.Parse(paises[3]);
            int anos = 0;

            while (anos <= 100 && pais1 <= pais2)
            {

                anos += 1;
                pais1 += (pais1 * cresci1 / 100);
                pais1 = (int)pais1;
                pais2 += (pais2 * cresci2 / 100);
                pais2 = (int)pais2;
            }
            if (anos > 100)
                Console.WriteLine("Mais de 1 seculo.");
            else
                Console.WriteLine(anos.ToString() + " anos.");

        }
    }
}