using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Adicionar
{
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent();
        }
        public Locacao Locacao;

        private void Button1_Click(object sender, EventArgs e)
        {
            Locacao = new Locacao
            {
                Livro = (int)comboLivro.SelectedValue,
                Tipo = int.Parse(textBox1.Text),
                Devolucao = dateDevolucao.Value,
                Usuario=1,
                Ativo= true,
                UsuInc = 1,
                UsuAlt = 1,
                DatInc = DateTime.Now,
                DatAlt = DateTime.Now
            };
            this.Close();
        }

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }
    }
}
