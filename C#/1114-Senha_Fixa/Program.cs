/*
autor: Guilherme Sampaio Dias
exercício: 1114- Senha Fixa
plataforma: Beecrowd
data: 23/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            int senha = int.Parse(Console.ReadLine());
            if (senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
                Console.WriteLine("Senha Invalida");
        }
    }
}