using System;

class Programa
{
    static void Main(string[] args)
    {
        int intervalo;

        intervalo = int.Parse(Console.ReadLine());

        for (int i = intervalo; i < 10000; i += intervalo)
        {
            Console.WriteLine(i);
        }
    }
}
