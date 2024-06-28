using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de veículos: ");
        int veiculos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o valor do aluguel por veículo: ");
        decimal valorAluguel = Convert.ToDecimal(Console.ReadLine());

        // Faturamento mensal considerando que 1/3 dos veículos são alugados
        decimal faturamentoMensal = (veiculos * valorAluguel) / 3;
        // Faturamento anual
        decimal faturamentoAnual = faturamentoMensal * 12;

        // Multa por atraso (1/10 dos veículos)
        decimal multa = (faturamentoMensal / 10) * 0.2m;

        // Valor gasto com manutenção (2% dos veículos)
        decimal manutencaoAnual = (veiculos * 0.02m) * 600;

        // Gravação dos resultados no arquivo resultado.txt
        using (StreamWriter writer = new StreamWriter("resultado.txt"))
        {
            writer.WriteLine($"Faturamento anual: R$ {faturamentoAnual}");
            writer.WriteLine($"Valor ganho com multas: R$ {multa}");
            writer.WriteLine($"Valor gasto com manutenção: R$ {manutencaoAnual}");
        }

        Console.WriteLine("Resultados gravados no arquivo resultado.txt.");
    }
}
