using Escola.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Aluno> alunos = new List<Aluno>();

        private void Bt1Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroAluno cadastro = new CadastroAluno();

            cadastro.ShowDialog();

            alunos.Add(cadastro.NovoAluno);

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ExibirAlunos exibir = new ExibirAlunos();
           
        }
    }
}
