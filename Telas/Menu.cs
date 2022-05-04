using Aula64_Exercicio_LocacaoLivros.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula64_Exercicio_LocacaoLivros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            LocarLivro locar = new LocarLivro();
            locar.ShowDialog();
                
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnDevovler_Click(object sender, EventArgs e)
        {
            DevolverLivro devolver = new DevolverLivro();
            devolver.ShowDialog();
        }

        private void btnManter_Click(object sender, EventArgs e)
        {
            ManterLivro manter = new ManterLivro();
            manter.ShowDialog();
        }
    }
}
