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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }

        private void Editoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDeDadosBibliotecaDataSet.Editoras' table. You can move, or remove it, as needed.
            // this.editorasTableAdapter1.Fill(this.baseDeDadosBibliotecaDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Editora = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.EditorasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEdicaoEditoras EditEditora = new frmEdicaoEditoras();
                        EditEditora.EditorasRow = Editora;
                        EditEditora.ShowDialog();

                        this.editorasTableAdapter.Update(EditEditora.EditorasRow);

                    }
                    break;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frnAdicionarEditoras addEdit = new frnAdicionarEditoras();
            addEdit.ShowDialog();

            this.editorasTableAdapter.Insert(addEdit.editora.Nome, addEdit.editora.Descricao);

            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

    }
}
