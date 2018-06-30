using Projeto_Cadastro.Biblioteca.Model;
using Projeto_Cadastro.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 5)
            {

                Console.WriteLine("=====================================");
                Console.WriteLine("############# MENU ##################\n");
                Console.WriteLine("= ESCOLHA UMA DAS SEGUINTES OPÇÕES =\n");
                Console.WriteLine("(1) - Cadastrar Cliente.");
                Console.WriteLine("(2) - Listar Cliente.");
                Console.WriteLine("(3) - Cadastar Funcionário.");
                Console.WriteLine("(4) - Listar Funcionário.");
                Console.WriteLine("(5) - Fechar.\n");
                Console.WriteLine("=====================================");
                Console.WriteLine("#####################################\n");
                Console.Write("Digite Uma Opção: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        new ManterCliente().CadastarCliente();
                        break;
                    case 2:
                        new ManterCliente().ListarCliente();
                        break;
                    case 3:
                        new ManterFuncionario().CadastrarFuncionário();
                        break;
                    case 4:
                        new ManterFuncionario().ListarFuncionario();
                        break;
                    case 5:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Você Não Digitou Um Valor Válido!");
                        break;
                }
            }
        }
    }
}
