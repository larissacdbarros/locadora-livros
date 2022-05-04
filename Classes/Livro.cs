using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula64_Exercicio_LocacaoLivros.Classes
{
    public class Livro
    {
        //public int Id { get; set; }
        //public string Categoria { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public int QtdPaginas { get; set; }
        public double ValorDiaria { get; set; }
        public double ValorLivroMercado { get; set; }
        public bool isLocado { get; set; }

        public Livro(string titulo, string autor, string editora, int anoPublicacao, 
                        int qtdPaginas, double valorLivroMercado)
        {
           
            this.Titulo = titulo;
            this.Autor  = autor;
            this.Editora = editora;
            this.AnoPublicacao = anoPublicacao;
            this.QtdPaginas = qtdPaginas;
            this.ValorLivroMercado = valorLivroMercado;
        }
        public Livro()
        {

        }

    }
}
