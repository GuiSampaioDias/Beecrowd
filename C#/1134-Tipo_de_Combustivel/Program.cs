/*
autor: Guilherme Sampaio Dias
exercício: 1134- Tipo de Combustivel
plataforma: Beecrowd
data: 27/09/2023
Linguagem: C#

*/
using System;

public class Program
{
    public static void Main()
    {
        int combustivel;
        int alcool = 0;
        int gasolina = 0;
        int disel = 0;
        while (true)
        {
            while (true)
            {
                combustivel = int.Parse(Console.ReadLine());
                if (combustivel <= 4 && combustivel >= 1)
                    break;
            }
            if (combustivel == 1)
                alcool += 1;
            else if (combustivel == 2)
                gasolina += 1;
            else if (combustivel == 3)
                disel += 1;
            else
                break;
        }
        Console.WriteLine("MUITO OBRIGADO\nAlcool: " + alcool + "\nGasolina: " + gasolina + "\nDiesel: " + disel);
    }
}