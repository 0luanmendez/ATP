using System;

class Program
{
    static void PreencherNotas(out int[] notas)
    {
        notas = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite a nota do aluno {i + 1}: ");
            notas[i] = int.Parse(Console.ReadLine());
        }
    }

    static void CalcularMediaEAcimaDaMedia(int[] notas)
    {
        int soma = 0;
        foreach (int nota in notas)
        {
            soma += nota;
        }
        double media = (double)soma / notas.Length;
        Console.WriteLine($"A média da turma é {media:f2}.");

        int acimaDaMedia = 0;
        foreach (int nota in notas)
        {
            if (nota > media)
                acimaDaMedia++;
        }
        Console.WriteLine($"{acimaDaMedia} aluno(s) obteve(am) nota acima da média.");
    }

    static void Main()
    {
        int[] notas;
        PreencherNotas(out notas);
        CalcularMediaEAcimaDaMedia(notas);
    }
}
