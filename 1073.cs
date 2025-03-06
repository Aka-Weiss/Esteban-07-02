using System;

class Programa
{
    static void Main(string[] args)
    {
        int limite;

        limite = int.Parse(Console.ReadLine());

        for (int i = 2; i <= limite; i += 2)
        {
            Console.WriteLine($"{i}^2 = {i * i}");
        }
    }
}
