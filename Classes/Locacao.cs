using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace Aula64_Exercicio_LocacaoLivros.Classes
{
    public class Locacao
    {
        public DateTime DtRetirada { get; set; }
        public DateTime DtDevolucao { get; set; }
        public DateTime DtRealDevolucao { get; set; }

        
        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }
        public double ValorLocacao { get; set; }
        public double Multa { get; set; }

        public Locacao(Cliente cliente, string dataRetirada, string dataDevolucao, Livro livro)
        {
            this.Cliente = cliente;
            this.DtRetirada = DateTime.Parse(dataRetirada);
            this.DtDevolucao = DateTime.Parse(dataDevolucao);
            this.Livro = livro;
        }


    }
}
