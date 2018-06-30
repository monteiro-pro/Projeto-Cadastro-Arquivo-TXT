using Projeto_Cadastro.Arquivo;
using Projeto_Cadastro.Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cadastro.Conversor
{
    public class ConverterCliente
    {
        public static string ConverterParaTexto(Cliente cliente)
        {
            return string.Format("{0}, {1}, {2}", 
                                 cliente.Nome, 
                                 cliente.DataNascimento, 
                                 cliente.Telefone);
        }

        public static Cliente ConverterParaCliente(string linha)
        {

            string[] Elementos = linha.Split(',');

            Cliente cliente = new Cliente();
            cliente.Nome = Elementos[0];
            cliente.DataNascimento = Convert.ToDateTime(Elementos[1]);
            cliente.Telefone = Elementos[2];

            return cliente;
        }
    }
}
