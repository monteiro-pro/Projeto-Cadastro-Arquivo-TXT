using Projeto_Cadastro.Arquivo;
using Projeto_Cadastro.Biblioteca.Model;
using Projeto_Cadastro.Conversor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cadastro.Telas
{
    class ManterFuncionario
    {
        public void CadastrarFuncionário()
        {
            Funcionario funcionario = new Funcionario();

            Console.Clear();

            Console.WriteLine("### CADASTRO DE FUNCIONÁRIO ###");
            Console.WriteLine("============================ \n");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            funcionario.Telefone = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            funcionario.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Cargo: ");
            funcionario.Cargo = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario.Salario = Convert.ToDouble(Console.ReadLine());

            GerenciadorArquivo.SalvarArquivo("Funcionario", ConverterFuncionario.ConverterParaTexto(funcionario));

            Console.Clear();

            Console.WriteLine("\n Funcionário Cadastrado Com Sucesso! \n");
        }

        public void ListarFuncionario()
        {
            Console.Clear();

            Console.WriteLine("### LISTA DE FUNCIONÁRIOS ###");
            Console.WriteLine("============================ \n");

            foreach (string linha in GerenciadorArquivo.LerArquivo("Funcionario"))
            {
                Funcionario funcionario = ConverterFuncionario.ConverterParaFuncionario(linha);
                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine("Data de Nascimento: " + funcionario.DataNascimento);
                Console.WriteLine("Telefone: " + funcionario.Telefone);
                Console.WriteLine("Cargo: " + funcionario.Cargo);
                Console.WriteLine("Salário: " + funcionario.Salario);
                Console.WriteLine("---------------------------\n");
            }

            Console.ReadKey();

            Console.Clear();
        }
    }
}
