using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploPoo.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);


            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoFiles = Directory.GetFiles(caminho, "*png*", SearchOption.AllDirectories); //"*" representa um filtro de todos os arquivos e pastas

            foreach (var retorno in retornoFiles)
            {
                Console.WriteLine(retorno);
            }

        }
        public void createDirect(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);

            Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CreateTxt(string caminho, string conteudo)
        {

            if (!File.Exists(caminho))
            {

                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CreateTxtStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho)) //using  controla a liberação do processo Stream
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);  //stream trabalha de forma assíncrona nesse caso na escrita linha por linha de um arquivo .txt
                }

            }

        }

        public void addTxt(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AddTxtStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha); 
                }

            }

        }

        public void LerArq(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }
        }

        public void LerArqStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) !=null)
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public void MoveFile(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopyFile(string caminho, string novoCaminho,bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever); 
        }

        public void DeleteFile(string caminho)
        {
            File.Delete(caminho);
        }
    }
}

