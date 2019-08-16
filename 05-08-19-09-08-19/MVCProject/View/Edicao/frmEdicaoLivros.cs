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

namespace MVCProject.View.Edicao
{
    public partial class frmEdicaoLivros : Form
    {
        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow LivrosRow;
        
        public frmEdicaoLivros()
        {
            InitializeComponent();
            


        }

        private void Editar_Click(object sender, EventArgs e)
        {
            LivrosRow.Registro = int.Parse(tbxRegistro.Text);
            LivrosRow.Titulo = tbxTitulo.Text;
            LivrosRow.Isbn = tbxIsbn.Text;
            LivrosRow.Genero = (int)comboGenero.SelectedValue;
            //LivrosRow.Editora = (int)comboEditora.SelectedValue;
            LivrosRow.Sinopse = tbxSinopse.Text;
            LivrosRow.Observacoes = tbxObservacao.Text;
            LivrosRow.Ativo = true;
            LivrosRow.UsuInc = 1;
            LivrosRow.UsuAlt = 1;
            LivrosRow.DatInc = DateTime.Now;
            LivrosRow.DatAlt = DateTime.Now;

            this.Close();
        }

        private void FrmEdicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            tbxRegistro.Text = LivrosRow.Registro.ToString();
            comboGenero.SelectedValue = LivrosRow.Genero.ToString();
           


        }
    }
}
