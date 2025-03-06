using System;

class Programa
{
    static void Main(string[] args)
    {
        int numero, maiorNumero = int.MinValue, posicaoMaiorNumero = 1;

        for (int i = 0; i < 100; ++i)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero > maiorNumero)
            {
                maiorNumero = numero;
                posicaoMaiorNumero = i + 1;
            }
        }

        Console.WriteLine(maiorNumero);
        Console.WriteLine(posicaoMaiorNumero);
    }
}
