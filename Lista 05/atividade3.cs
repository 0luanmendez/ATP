using System;

class Program
{
    static void PreencherVetor(out int[] X)
    {
        X = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            X[i] = rnd.Next(-10, 11); // Números aleatórios entre -10 e 10
        }
    }

    static int[] CopiarNegativos(int[] vetor)
    {
        int countNegativos = 0;
        foreach (int num in vetor)
        {
            if (num < 0)
                countNegativos++;
        }

        int[] negativos = new int[countNegativos];
        int index = 0;
        foreach (int num in vetor)
        {
            if (num < 0)
                negativos[index++] = num;
        }

        return negativos;
    }

    static void ExibirVetor(int[] vetor)
    {
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] X;
        PreencherVetor(out X);
        ExibirVetor(X);

        int[] negativos = CopiarNegativos(X);
        Console.WriteLine("Vetor com números negativos:");
        ExibirVetor(negativos);
    }
}
