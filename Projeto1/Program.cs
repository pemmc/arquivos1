using System;
using System.IO;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {

            //windows
            //string sourcePath = "c:\\temp\\arquivotexto.txt";
            //ou
            //string sourcePath = @"c:\temp\arquivotexto.txt";

            //mac
            // diretorio padrao '/Users/nxgames/Projects/Solucao1/Projeto1/bin/Debug/netcoreapp3.1/arquivotexto.txt

            string sourcePath = "/Users/nxgames/Projects/Solucao1/Projeto1/arquivotexto.txt";
            string targetPath = "/Users/nxgames/Projects/Solucao1/Projeto1/arquivotexto2.txt";

            try
            {
                //Instanciei arquivo
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);


                //Nao precisei instanciar, por isso passei o arquivo
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);

                }

            }

            catch (IOException e )
            {

                Console.WriteLine("IO ERROR: " + e.Message );
            }


        }
    }
}
