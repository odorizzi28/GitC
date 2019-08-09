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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

       public  Aluno NovoAluno = new Aluno();
        private void Button1_Click(object sender, EventArgs e)
        {


            NovoAluno.Nome = tbxNome.Text;
            NovoAluno.Idade = int.Parse(tbxidade.Text);
       

            this.Close();
            
        }
    }
}
