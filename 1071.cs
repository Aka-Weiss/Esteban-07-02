using System;

class Programa
{
    static void Main(string[] args)
    {
        int inicio = int.Parse(Console.ReadLine());
        int fim = int.Parse(Console.ReadLine());

        if (inicio > fim)
        {
            int temp = inicio;
            inicio = fim;
            fim = temp;
        }

        inicio += (Math.Abs(inicio) % 2) + 1;
        fim -= (Math.Abs(fim) % 2) + 1;

        int soma = 0;
        for (int i = inicio; i <= fim; i += 2)
        {
            soma += i;
        }

        Console.WriteLine(soma);
    }
}
