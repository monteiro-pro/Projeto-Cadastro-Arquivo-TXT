using Projeto_Cadastro.Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cadastro.Arquivo
{
    public class GerenciadorArquivo
    {
        public static void SalvarArquivo(string nome, string texto)
        {
            string Caminho = "D:\\Documentos\\Material de Estudo\\Analise e Desenvolvimento de Sistemas\\Linguagem C#\\Curso C#\\Projetos de Aula\\Solution\\Arquivos_Aula\\Arquivo" + nome + ".txt";

            if (File.Exists(Caminho))
            {
                using(StreamWriter arquivo = File.AppendText(Caminho))
                {
                    arquivo.WriteLine(texto);

                    arquivo.Close();
                    arquivo.Dispose();
                }
            }
            else
            {
                using (StreamWriter arquivo = new StreamWriter(Caminho))
                {
                    arquivo.WriteLine(texto);

                    arquivo.Close();
                    arquivo.Dispose();
                }
            }
            
        }

        public static string[] LerArquivo(string nome)
        {
            string Caminho = "D:\\Documentos\\Material de Estudo\\Analise e Desenvolvimento de Sistemas\\Linguagem C#\\Curso C#\\Projetos de Aula\\Solution\\Arquivos_Aula\\Arquivo" + nome + ".txt";

            return File.ReadAllLines(Caminho);
        }
    }
}
