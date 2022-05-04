using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula64_Exercicio_LocacaoLivros.Classes
{
    public class Cliente
    {
        string Nome { get; set; }
        string Cpf { get; set; }

        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

    }
}
