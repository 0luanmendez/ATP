using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite o caminho completo do arquivo de texto: ");
        string caminhoArquivo = Console.ReadLine();

        try
        {
            string conteudo = File.ReadAllText(caminhoArquivo);
            int contador = 0;

            foreach (char caractere in conteudo)
            {
                if (caractere == 'a' || caractere == 'A')
                    contador++;
            }

            Console.WriteLine($"Quantidade de caracteres 'a' no arquivo: {contador}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado. Verifique o caminho informado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
        }
    }
}
