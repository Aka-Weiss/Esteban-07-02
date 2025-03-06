using System;

class Programa
{
    static void Main(string[] args)
    {
        int quantidade, numero;

        quantidade = int.Parse(Console.ReadLine());

        int dentroIntervalo = 0;
        for (int i = 0; i < quantidade; ++i)
        {
            numero = int.Parse(Console.ReadLine());

            if (10 <= numero && numero <= 20)
            {
                ++dentroIntervalo;
            }
        }

        Console.WriteLine($"{dentroIntervalo} in");
        Console.WriteLine($"{quantidade - dentroIntervalo} out");
    }
}
