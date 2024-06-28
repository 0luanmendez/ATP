using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "caminho_do_arquivo.txt"; 

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;
            double sum = 0;
            int count = 0;

            foreach (string line in lines)
            {
                if (double.TryParse(line, out double value))
                {
                    minValue = Math.Min(minValue, value);
                    maxValue = Math.Max(maxValue, value);
                    sum += value;
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"Valor mínimo: {minValue}");
                Console.WriteLine($"Valor máximo: {maxValue}");
                Console.WriteLine($"Média: {average}");
            }
            else
            {
                Console.WriteLine("Nenhum valor válido encontrado no arquivo.");
            }
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}

