using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula64_Exercicio_LocacaoLivros.Classes
{
    public class LivrosRepository
    {
        public static List<Livro> InicializaRepository()
        {
            List<Livro> lista = new List<Livro>();
            {
                lista.Add(new Livro("Maus", "Art Spiegelman", "Quadrinhos na Cia", 2005, 296, 55.92));
                lista.Add(new Livro("A hipótese do amor", "Ali Hazelwood", "Editora Arqueiro Ltda", 2022, 366, 49.90));
                lista.Add(new Livro("É Assim que Acaba", "Colleen Hoover ", "Editora Galera", 2018, 368, 29.60));
                lista.Add(new Livro("A garota do lago", "Charlie Donlea", "Faro Editorial", 2017, 296, 59.90));
                lista.Add(new Livro("O homem mais rico da Babilônia", "George S Clason", "Editora HarperCollins", 2017, 160, 34.90));
                lista.Add(new Livro("Mulheres que correm com os lobos", "Clarissa Pinkola Estés", " Editora Rocco", 2018, 576, 34.90));
                lista.Add(new Livro("Pai rico, pai pobre", "Robert T. Kiyosaki", "Editora Alta Books", 2017, 336, 30.99));

            }
            return lista;
        }


    }

}

