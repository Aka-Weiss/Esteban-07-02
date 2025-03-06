using System;

class Programa
{
    static void Main(string[] args)
    {
        int numeroLimite = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= numeroLimite; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
