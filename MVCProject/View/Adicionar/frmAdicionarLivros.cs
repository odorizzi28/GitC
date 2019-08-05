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
    public partial class frmAdicionarLivros : Form
    {
        public frmAdicionarLivros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;
        public Livro LivroRow;
        private void Adicionar_Click(object sender, EventArgs e)
        {
            LivroRow = new Livro();
            LivroRow.Registro = int.Parse(tbxRegistro.Text);
            LivroRow.Titulo = tbxTitulo.Text;
            LivroRow.ISBN = tbxIsbn.Text;
            LivroRow.Genero = (int)ComboGenero.SelectedValue;
            LivroRow.Editora = (int)comboEditora.SelectedValue;
            LivroRow.Sinopse = tbxSinopse.Text;
            LivroRow.Observacao = tbxObservacçoes.Text;
            LivroRow.Ativo = true;
            LivroRow.UsuInc = 1;
            LivroRow.UsuAlt = 1;
            LivroRow.DatInc = DateTime.Now;
            LivroRow.DatAlt = DateTime.Now;

            this.Close();

        }

        private void FrmAdicionarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }
    }
}
