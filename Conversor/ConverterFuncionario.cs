using Projeto_Cadastro.Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cadastro.Conversor
{
    public class ConverterFuncionario
    {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", 
                                 funcionario.Nome, 
                                 funcionario.DataNascimento, 
                                 funcionario.Telefone, 
                                 funcionario.Cargo, 
                                 funcionario.Salario);
        }

        public static Funcionario ConverterParaFuncionario(string linha)
        {
            string[] Elemento = linha.Split(',');

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = Elemento[0];
            funcionario.DataContratacao =DateTime.Parse(Elemento[1]);
            funcionario.Telefone = Elemento[2];
            funcionario.Cargo = Elemento[3];
            funcionario.Salario = double.Parse(Elemento[4]);

            return funcionario;
        }
    }
}
