using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "seuarquivo.txt"; 

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int lineCount = 0;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); 
                    lineCount++;
                }

                Console.WriteLine($"O arquivo possui {lineCount} linhas.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado. Verifique o caminho.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
