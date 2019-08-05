using MVCProject.View.Adicionar;
using MVCProject.View.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet1.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet1.Livros);
            // TODO: This line of code loads data into the 'baseDeDadosBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            //this.livrosTableAdapter1.Fill(this.baseDeDadosBibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livro = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.DeleteQuery(livro.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoLivros addLivros = new frmEdicaoLivros();
                        addLivros.LivrosRow = livro;
                        addLivros.ShowDialog();

                        this.livrosTableAdapter.Update(addLivros.LivrosRow);
                    }
                    break;

            }
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivros addLivro = new frmAdicionarLivros();
            addLivro.ShowDialog();
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }
    }

}
