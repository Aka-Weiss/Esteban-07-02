using System;

class Programa
{
    static void Main(string[] args)
    {
        int numeroDeTestes = int.Parse(Console.ReadLine());

        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

        for (int i = 0; i < numeroDeTestes; ++i)
        {
            string[] entrada = Console.ReadLine().Trim().Split(' ');
            int quantidade = int.Parse(entrada[0]);
            string tipoDeCobaia = entrada[1];

            switch (tipoDeCobaia)
            {
                case "C":
                    totalCoelhos += quantidade;
                    break;
                case "R":
                    totalRatos += quantidade;
                    break;
                case "S":
                    totalSapos += quantidade;
                    break;
            }
        }

        int totalCobaias = totalCoelhos + totalRatos + totalSapos;

        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {totalCoelhos}");
        Console.WriteLine($"Total de ratos: {totalRatos}");
        Console.WriteLine($"Total de sapos: {totalSapos}");
        Console.WriteLine($"Percentual de coelhos: {(double)totalCoelhos / totalCobaias * 100:0.00} %");
        Console.WriteLine($"Percentual de ratos: {(double)totalRatos / totalCobaias * 100:0.00} %");
        Console.WriteLine($"Percentual de sapos: {(double)totalSapos / totalCobaias * 100:0.00} %");
    }
}
