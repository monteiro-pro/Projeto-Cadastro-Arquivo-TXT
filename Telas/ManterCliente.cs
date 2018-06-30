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
    class ManterCliente
    {
        public void CadastarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Clear();

            Console.WriteLine("### CADASTRO DE CLIENTE ###");
            Console.WriteLine("============================ \n");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            GerenciadorArquivo.SalvarArquivo("Cliente", ConverterCliente.ConverterParaTexto(cliente));

            Console.Clear();

            Console.WriteLine("\n Cliente Cadastrado Com Sucesso! \n");
        }

        public void ListarCliente()
        {
            Console.Clear();

            Console.WriteLine("### LISTA DE CLIENTES ###");
            Console.WriteLine("============================ \n");

            foreach(string linha in GerenciadorArquivo.LerArquivo("Cliente"))
            {
                Cliente cliente = ConverterCliente.ConverterParaCliente(linha);
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Data de Nascimento: " + cliente.DataNascimento);
                Console.WriteLine("Telefone: " + cliente.Telefone);
                Console.WriteLine("------------------------------------\n");
            }

            Console.ReadKey();

            Console.Clear();
        }
    }
}
