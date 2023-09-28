/*
autor: Guilherme Sampaio Dias
exercício: 1118- Varias Notas com Validação
plataforma: Beecrowd
data: 2709/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            int res = 0;
            double total = 0;
            for (int i = 0; i < 2; i++)
            {
                while (true)
                {
                    double valor = double.Parse(Console.ReadLine());
                    if (valor >= 0 && valor <= 10)
                    {
                        total += valor;
                        break;
                    }
                    else
                        Console.WriteLine("nota invalida");
                }
            }
            double media = total / 2;
            string media_f = media.ToString("f2");
            Console.WriteLine("media = " + media_f);
            while (true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                res = int.Parse(Console.ReadLine());
                if (res == 1 || res == 2)
                    break;
            }
            if (res == 2)
                break;
        }
    }
}