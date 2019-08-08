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

        public Livro Livro;
        private void Adicionar_Click(object sender, EventArgs e)
        {
            Livro = new Livro
            {
                Registro = int.Parse(tbxRegistro.Text),
                Titulo = tbxTitulo.Text,
                ISBN = tbxIsbn.Text,
                Genero = (int)ComboGenero.SelectedValue,
                Editora = (int)comboEditora.SelectedValue,
                Sinopse = tbxSinopse.Text,
                Observacao = tbxObservacçoes.Text,
                Ativo = true,
                UsuInc = 1,
                UsuAlt = 1,
                DatInc = DateTime.Now,
                DatAlt = DateTime.Now,
        };                
        
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
