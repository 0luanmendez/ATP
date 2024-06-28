using System;
using System.Collections.Generic;
using System.IO;

class Aluno
{
    public string Matricula { get; set; }
    public string Telefone { get; set; }
}

class Program
{
    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();

        // Opção para inserir dados de alunos
        Console.WriteLine("1. Inserir dados de alunos");
        Console.WriteLine("2. Ler dados de alunos do arquivo");
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("Digite a matrícula do aluno: ");
            string matricula = Console.ReadLine();

            Console.Write("Digite o telefone do aluno: ");
            string telefone = Console.ReadLine();

            alunos.Add(new Aluno { Matricula = matricula, Telefone = telefone });

            // Salvar no arquivo
            using (StreamWriter writer = new StreamWriter("alunos.txt", true))
            {
                writer.WriteLine($"{matricula},{telefone}");
            }

            Console.WriteLine("Dados do aluno salvos!");
        }
        else if (opcao == 2)
        {
            // Ler dados do arquivo
            using (StreamReader reader = new StreamReader("alunos.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] partes = linha.Split(',');
                    alunos.Add(new Aluno { Matricula = partes[0], Telefone = partes[1] });
                }
            }

            Console.WriteLine("Dados dos alunos lidos do arquivo:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Matrícula: {aluno.Matricula}, Telefone: {aluno.Telefone}");
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
