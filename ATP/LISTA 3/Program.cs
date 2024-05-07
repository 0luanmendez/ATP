//1 Contar o número de valores positivos, negativos e zeros://


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de números inteiros separados por espaço:");
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int positiveCount = numbers.Count(n => n > 0);
        int negativeCount = numbers.Count(n => n < 0);
        int zeroCount = numbers.Count(n => n == 0);

        Console.WriteLine($"Positivos: {positiveCount}, Negativos: {negativeCount}, Zeros: {zeroCount}");
    }
}
// 2 - Calcular o percentual dos valores positivos, negativos e zeros://


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma sequência de números inteiros separados por espaço:");
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int total = numbers.Count;
        double positivePercentage = (double)numbers.Count(n => n > 0) / total * 100;
        double negativePercentage = (double)numbers.Count(n => n < 0) / total * 100;
        double zeroPercentage = (double)numbers.Count(n => n == 0) / total * 100;

        Console.WriteLine($"Positivos: {positivePercentage}%, Negativos: {negativePercentage}%, Zeros: {zeroPercentage}%");
    }
}
//3.Verificar se os números são divisíveis por 3 e 9, por 2 e por 5://

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite dez números inteiros separados por espaço:");
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int divisibleBy3And9 = numbers.Count(n => n % 3 == 0 && n % 9 == 0);
        int divisibleBy2 = numbers.Count(n => n % 2 == 0);
        int divisibleBy5 = numbers.Count(n => n % 5 == 0);

        Console.WriteLine($"Divisíveis por 3 e 9: {divisibleBy3And9}, Divisíveis por 2: {divisibleBy2}, Divisíveis por 5: {divisibleBy5}");
    }
}
//4.Calcular o fatorial de um número://


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        long factorial = Factorial(number);
        Console.WriteLine($"O fatorial de {number} é {factorial}.");
    }

    static long Factorial(int number)
    {
        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
// 5. Calcular o valor de E:


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro e positivo:");
        int number = int.Parse(Console.ReadLine());

        double e = 1;
        for (int i = 1; i <= number; i++)
        {
            e += 1 / Factorial(i);
        }

        Console.WriteLine($"O valor de E é {e}.");
    }

    static double Factorial(int number)
    {
        double result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
// 6 - Calcular a média do salário da população, a média do número de filhos, o maior salário e o percentual de pessoas com salário até R$100,00://


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var salaries = new List<double>();
        var childrenCounts = new List<int>();

        while (true)
        {
            Console.WriteLine("Digite o salário:");
            double salary = double.Parse(Console.ReadLine());
            if (salary < 0) break;

            Console.WriteLine("Digite o número de filhos:");
            int childrenCount = int.Parse(Console.ReadLine());

            salaries.Add(salary);
            childrenCounts.Add(childrenCount);
        }

        double averageSalary = salaries.Average();
        double averageChildrenCount = childrenCounts.Average();
        double maxSalary = salaries.Max();
        double percentageBelow100 = salaries.Count(s => s <= 100) / (double)salaries.Count * 100;

        Console.WriteLine($"Média do salário: {averageSalary}, Média do número de filhos: {averageChildrenCount}, Maior salário: {maxSalary}, Percentual com salário até R$100,00: {percentageBelow100}%");
    }
}
// 7 . Calcular a soma S:


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro e positivo:");
        int number = int.Parse(Console.ReadLine());

        double s = 0;
        for (int i = 1; i <= number; i++)
        {
            s += 1 / (double)i;
            Console.WriteLine($"Termo {i}: {1 / (double)i}");
        }

        Console.WriteLine($"O valor final de S é {s}.");
    }
}
/// 8 .Imprimir os L primeiros elementos da série de Fibonacci:


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        int l = int.Parse(Console.ReadLine());

        long a = 0;
        long b = 1;

        for (int i = 0; i < l; i++)
        {
            Console.WriteLine(a);
            long temp = a;
            a = b;
            b = temp + b;
        }
    }
}
// 9 .Imprimir a soma de todos os elementos da série de Fibonacci menores que L:


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        int l = int.Parse(Console.ReadLine());

        long a = 0;
        long b = 1;
        long sum = 0;

        while (a < l)
        {
            sum += a;
            long temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"A soma de todos os elementos da série de Fibonacci menores que {l} é {sum}.");
    }
}
// 10. Fazer o levantamento do lucro das mercadorias://


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var profits = new List<double>();
        double totalPurchase = 0;
        double totalSale = 0;

        while (true)
        {
            Console.WriteLine("Digite o preço de compra:");
            double purchasePrice = double.Parse(Console.ReadLine());
            if (purchasePrice == 0) break;

            Console.WriteLine("Digite o preço de venda:");
            double salePrice = double.Parse(Console.ReadLine());

            totalPurchase += purchasePrice;
            totalSale += salePrice;
            profits.Add((salePrice - purchasePrice) / purchasePrice * 100);
        }

        int countProfitLessThan10 = profits.Count(p => p < 10);
        int countProfitBetween10And20 = profits.Count(p => p >= 10 && p <= 20);
        int countProfitGreaterThan20 = profits.Count(p => p > 20);

        Console.WriteLine($"Mercadorias com lucro < 10%: {countProfitLessThan10}, Mercadorias com 10% <= lucro <= 20%: {countProfitBetween10And20}, Mercadorias com lucro > 20%: {countProfitGreaterThan20}");
        Console.WriteLine($"Valor total de compra: {totalPurchase}, Valor total de venda: {totalSale}, Lucro total: {totalSale - totalPurchase}");
    }
}
// 11. Calcular o total de votos para cada candidato, o total de votos nulos e o total de votos em branco:


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var votes = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } };

        while (true)
        {
            Console.WriteLine("Digite o código do candidato:");
            int code = int.Parse(Console.ReadLine());
            if (code == 0) break;

            if (votes.ContainsKey(code))
            {
                votes[code]++;
            }
        }

        Console.WriteLine($"Total de votos para o candidato 1: {votes[1]}, Total de votos para o candidato 2: {votes[2]}, Total de votos para o candidato 3: {votes[3]}, Total de votos para o candidato 4: {votes[4]}, Total de votos nulos: {votes[5]}, Total de votos em branco: {votes[6]}");
    }
}