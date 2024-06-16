using System;

class Program
{
    static void PreencherVetores(out int[] X, out int[] Y)
    {
        X = new int[10];
        Y = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            X[i] = rnd.Next(1, 101); // Números aleatórios entre 1 e 100
            Y[i] = rnd.Next(101, 201); // Números aleatórios entre 101 e 200
        }
    }

    static void Intercalar(int[] X, int[] Y, out int[] intercalado)
    {
        intercalado = new int[20];
        for (int i = 0; i < 10; i++)
        {
            intercalado[2 * i] = X[i];       // Posições pares
            intercalado[2 * i + 1] = Y[i];   // Posições ímpares
        }
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
        int[] X, Y;
        PreencherVetores(out X, out Y);
        ExibirVetor(X);
        ExibirVetor(Y);

        int[] intercalado;
        Intercalar(X, Y, out intercalado);
        Console.WriteLine("Vetor intercalado:");
        ExibirVetor(intercalado);
    }
}
