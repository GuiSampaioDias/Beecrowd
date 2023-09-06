/* Esse Código não está pronto*/

using System;

class Program
{
    static void Main()
    {
        string pri = Console.ReadLine();
        string[] primeiro = pri.Split(' ');
        double.TryParse(primeiro[1], out double quant1);
        double.TryParse(primeiro[2], out double valor1);
        double tot = quant1 * valor1;
        Console.WriteLine(tot);
    }
}
