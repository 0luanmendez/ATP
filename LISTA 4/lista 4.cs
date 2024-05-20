//1 - Média de notas de alunos:


using System;

class Program {
    static void Main() {
        Console.Write("Digite o número de alunos: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            Console.Write("Digite as 3 notas do aluno e a letra (A ou P): ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());
            char letra = char.Parse(Console.ReadLine());
            CalculaMedia(nota1, nota2, nota3, letra);
        }
    }

    static void CalculaMedia(double nota1, double nota2, double nota3, char letra) {
        double media;
        if (letra == 'A') {
            media = (nota1 + nota2 + nota3) / 3;
        } else {
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
        }
        Console.WriteLine("A média do aluno é: " + media);
    }
}

// 2 - Média de salário da população:


using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<double> salarios = new List<double>();
        while (true) {
            Console.Write("Digite o salário (ou -1 para parar): ");
            double salario = double.Parse(Console.ReadLine());
            if (salario == -1) {
                break;
            }
            salarios.Add(salario);
        }
        CalculaMediaSalario(salarios);
    }

    static void CalculaMediaSalario(List<double> salarios) {
        double soma = 0;
        foreach (double salario in salarios) {
            soma += salario;
        }
        double media = soma / salarios.Count;
        Console.WriteLine("A média de salário da população é: " + media);
    }
}
// 3 - Exibir valores em ordem crescente:


using System;

class Program {
    static void Main() {
        Console.Write("Digite o número de conjuntos: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            Console.Write("Digite 3 valores: ");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            ExibeValoresEmOrdem(valor1, valor2, valor3);
        }
    }

    static void ExibeValoresEmOrdem(int valor1, int valor2, int valor3) {
        int[] valores = new int[] { valor1, valor2, valor3 };
        Array.Sort(valores);
        Console.WriteLine("Os valores em ordem são: " + valores[0] + ", " + valores[1] + ", " + valores[2]);
    }
}

//4- Verificar se valores podem formar um triângulo:


using System;

class Program {
    static void Main() {
        while (true) {
            Console.Write("Digite 3 valores (ou -1 para parar): ");
            double valor1 = double.Parse(Console.ReadLine());
            if (valor1 == -1) {
                break;
            }
            double valor2 = double.Parse(Console.ReadLine());
            double valor3 = double.Parse(Console.ReadLine());
            VerificaTriangulo(valor1, valor2, valor3);
        }
    }

    static void VerificaTriangulo(double valor1, double valor2, double valor3) {
        if (valor1 + valor2 > valor3 && valor1 + valor3 > valor2 && valor2 + valor3 > valor1) {
            if (valor1 == valor2 && valor2 == valor3) {
                Console.WriteLine("Triângulo Equilátero");
            } else if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3) {
                Console.WriteLine("Triângulo Isósceles");
            } else {
                Console.WriteLine("Triângulo Escaleno");
            }
        } else {
            Console.WriteLine("Os valores não podem formar um triângulo");
        }
    }
}
// 5 - Algoritmo de Euclides para MDC:


using System;

class Program {
    static void Main() {
        Console.Write("Digite dois números: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int mdc = CalculaMDC(num1, num2);
        Console.WriteLine("O MDC é: " + mdc);
    }

    static int CalculaMDC(int num1, int num2) {
        while (num2 != 0) {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
}

//6 - Verificar se um valor é positivo ou negativo:


using System;

class Program {
    static void Main() {
        Console.Write("Digite o número de números: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            bool isPositive = VerificaPositivo(num);
            Console.WriteLine("O número é positivo? " + isPositive);
        }
    }

    static bool VerificaPositivo(int num) {
        return num >= 0;
    }
}

// 7 -Identificar o conceito de um aluno:


using System;

class Program {
    static void Main() {
        Console.Write("Digite o número de alunos: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            Console.Write("Digite a média do aluno: ");
            double media = double.Parse(Console.ReadLine());
            IdentificaConceito(media);
        }
    }

    static void IdentificaConceito(double media) {
        char conceito;
        if (media <= 39) {
            conceito = 'F';
        } else if (media <= 59) {
            conceito = 'E';
        } else if (media <= 69) {
            conceito = 'D';
        } else if (media <= 79) {
            conceito = 'C';
        } else if (media <= 89) {
            conceito = 'B';
        } else {
            conceito = 'A';
        }
        Console.WriteLine("O conceito do aluno é: " + conceito);
    }
}

// 8 -Calcular o valor de S:


using System;

class Program {
    static void Main() {
        Console.Write("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());
        double s = CalculaS(n);
        Console.WriteLine("O valor de S é: " + s);
    }

    static double CalculaS(int n) {
        double s = 0;
        for (int i = 1; i <= n; i++) {
            s += (double)(i * i + 1) / (i + 3);
        }
        return s;
    }
}

// 9 - Calcular a média das notas dos alunos aprovados:

using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        Console.Write("Digite o número de alunos: ");
        int n = int.Parse(Console.ReadLine());
        List<double> notas = new List<double>();
        for (int i = 0; i < n; i++) {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }
        double media = CalculaMediaAprovados(notas);
        Console.WriteLine("A média das notas dos alunos aprovados é: " + media);
    }

    static double CalculaMediaAprovados(List<double> notas) {
        double soma = 0;
        int count = 0;
        foreach (double nota in notas) {
            if (nota >= 6) {
                soma += nota;
                count++;
            }
        }
        return soma / count;
    }
}
// 10 - Identificar a categoria de um nadador:


using System;

class Program {
    static void Main() {
        Console.Write("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());
        char categoria = IdentificaCategoria(idade);
        Console.WriteLine("A categoria do nadador é: " + categoria);
    }

    static char IdentificaCategoria(int idade) {
        if (idade <= 7) {
            return 'F';
        } else if (idade <= 10) {
            return 'E';
        } else if (idade <= 13) {
            return 'D';
        } else if (idade <= 15) {
            return 'C';
        } else if (idade <= 17) {
            return 'B';
        } else {
            return 'A';
        }
    }
}