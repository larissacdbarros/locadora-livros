using Aula64_Exercicio_LocacaoLivros.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula64_Exercicio_LocacaoLivros.Telas
{
    public partial class LocarLivro : Form
    {
        List<Livro> allBooks = LivrosRepository.InicializaRepository();
        Livro livro = new Livro();
        public LocarLivro()
        {
            InitializeComponent();
        }

        private void LocarLivro_Load(object sender, EventArgs e)
        {
           
            foreach (Livro l in allBooks)
            {
                comboBox1.DataSource = allBooks;
                comboBox1.DisplayMember = "titulo";
                comboBox1.ValueMember = "titulo";
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            allBooks[comboBox1.SelectedIndex] = livro;   
            
        }

        private void btnManter_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente(txtNome.Text,txtCPF.Text);
            Locacao locacao = new Locacao(cliente, txtDataRetirada.Text, txtDataDevolucao.Text, livro); 

        }
    }
}
