using System;

class Program
{
    static void Main()
    {
        int[,] M = new int[10, 10];

        // Preencher a matriz M 10x10
        PreencherMatriz(M);

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(M);

        // a) Trocar a linha 2 com a linha 8
        TrocarLinhas(M, 2, 8);
        Console.WriteLine("\nMatriz após troca da linha 2 com a linha 8:");
        ImprimirMatriz(M);

        //b) Trocar a coluna 4 com a coluna 10
        TrocarColunas(M, 4, 9); // 4 e 9 porque as colunas são indexadas de 0 a 9
        Console.WriteLine("\nMatriz após troca da coluna 4 com a coluna 10:");
        ImprimirMatriz(M);

        //c) Trocar a diagonal principal com a diagonal secundária
        TrocarDiagonais(M);
        Console.WriteLine("\nMatriz após troca da diagonal principal com a diagonal secundária:");
        ImprimirMatriz(M);

        //d) Trocar a linha 5 com a coluna 10
        TrocarLinhaComColuna(M, 5, 9);
        Console.WriteLine("\nMatriz após troca da linha 5 com a coluna 10:");
        ImprimirMatriz(M);
    }
    }

    // Procedimento para preencher uma matriz 10x10
    static void PreencherMatriz(int[,] M)
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                M[i, j] = rnd.Next(1, 101); // Números aleatórios entre 1 e 100
            }
        }
    }

    // Procedimento para trocar duas linhas da matriz
    static void TrocarLinhas(int[,] M, int linha1, int linha2)
    {
        for (int j = 0; j < 10; j++)
        {
            int temp = M[linha1, j];
            M[linha1, j] = M[linha2, j];
            M[linha2, j] = temp;
        }
    }

    // Procedimento para trocar duas colunas da matriz
    static void TrocarColunas(int[,] M, int coluna1, int coluna2)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = M[i, coluna1];
            M[i, coluna1] = M[i, coluna2];
            M[i, coluna2] = temp;
        }
    }

    //e) Procedimento para trocar a diagonal principal com a diagonal secundária
    static void TrocarDiagonais(int[,] M)
    {
        for (int i = 0; i < 10; i++)
        {
            int temp = M[i, i];
            M[i, i] = M[i, 9 - i];
            M[i, 9 - i] = temp;
        }
    }

    // Função para imprimir uma matriz
    static void ImprimirMatriz(int[,] M)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(M[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
