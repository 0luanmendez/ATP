using System;

class Program
{
    static void PreencherMatrizes(out int[,] A, out int[,] B)
    {
        A = new int[4, 6];
        B = new int[4, 6];
        Random rnd = new Random();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                A[i, j] = rnd.Next(1, 101); // Números aleatórios entre 1 e 100
                B[i, j] = rnd.Next(1, 101); // Números aleatórios entre 1 e 100
            }
        }
    }

    static int[,] SomaMatrizes(int[,] A, int[,] B)
    {
        int[,] S = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                S[i, j] = A[i, j] + B[i, j];
            }
        }
        return S;
    }

    static int[,] DiferencaMatrizes(int[,] A, int[,] B)
    {
        int[,] D = new int[4, 6];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                D[i, j] = A[i, j] - B[i, j];
            }
        }
        return D;
    }

    static void Main()
    {
        int[,] A, B;
        PreencherMatrizes(out A, out B);

        Console.WriteLine("Matriz A:");
        ImprimirMatriz(A);
        Console.WriteLine("Matriz B:");
        ImprimirMatriz(B);

        int[,] Soma = SomaMatrizes(A, B
