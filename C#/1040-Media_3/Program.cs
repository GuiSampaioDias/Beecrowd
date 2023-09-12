/*
autor: Guilherme Sampaio Dias
exercício: 1040- Média 3
plataforma: Beecrowd
data: 11/09/2023
Linguagem: C#

*/
using System;

public class Media_3
{
    public static void Main()
    {
        string notas = Console.ReadLine();
        string[] nota = notas.Split(' ');
        double.TryParse(nota[0], out double N1);
        double.TryParse(nota[1], out double N2);
        double.TryParse(nota[2], out double N3);
        double.TryParse(nota[3], out double N4);

        double med = ((2 * N1) + (3 * N2) + (4 * N3) + N4) / 10.0;
        double media = Math.Round(med, 1);
        string media_f = media.ToString("f1");
        Console.WriteLine("Media: " + media_f);
        if (media >= 7.0)
            Console.WriteLine("Aluno aprovado.");
        else if (media >= 5 && media <= 6.9)
        {
            Console.WriteLine("Aluno em exame.");
            double exame = double.Parse(Console.ReadLine());
            string nota_exame = exame.ToString("f1");
            Console.WriteLine("Nota do exame: " + nota_exame);
            double media2 = (media + exame) / 2.0;
            if (media2 >= 5.0)
                Console.WriteLine("Aluno aprovado.");

            else
                Console.WriteLine("Aluno reprovado.");
            string media_final = media2.ToString("f1");
            Console.WriteLine("Media final: " + media_final);
        }
        else
            Console.WriteLine("Aluno reprovado.");
    }
}