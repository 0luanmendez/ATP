using System;

class Program
{
    static void Main()
    {
        int[] temperaturas = new int[31]; // Vetor para armazenar as temperaturas de outubro

        Random rnd = new Random();
        for (int i = 0; i < 31; i++)
        {
            temperaturas[i] = rnd.Next(15, 41); // Temperaturas aleatórias entre 15°C e 40°C
        }

        // Encontrar menor e maior temperatura
        int menor = temperaturas[0];
        int maior = temperaturas[0];
        int soma = 0;
        foreach (int temp in temperaturas)
        {
            if (temp < menor)
                menor = temp;
            if (temp > maior)
                maior = temp;
            soma += temp;
        }

        double media = (double)soma / 31;

        Console.WriteLine($"Menor temperatura: {menor}°C");
        Console.WriteLine($"Maior temperatura: {maior}°C");
        Console.WriteLine($"Temperatura média: {media:f2}°C");

        int abaixoDaMedia = 0;
        foreach (int temp in temperaturas)
        {
            if (temp < media)
                abaixoDaMedia++;
        }

        Console.WriteLine($"Número de dias com temperatura abaixo da média: {abaixoDaMedia}");
    }
}
