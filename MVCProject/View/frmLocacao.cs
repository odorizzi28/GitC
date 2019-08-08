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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void Locacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDeDadosBibliotecaDataSet.Usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.baseDeDadosBibliotecaDataSet.Usuarios);
            // TODO: This line of code loads data into the 'baseDeDadosBibliotecaDataSet.Locacao' table. You can move, or remove it, as needed.
            //this.locacaoTableAdapter1.Fill(this.baseDeDadosBibliotecaDataSet.Locacao);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacao = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacao.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoLocacao EditLocacao = new frmEdicaoLocacao();
                        EditLocacao.locacaoRow = locacao;
                        EditLocacao.ShowDialog();

                        this.locacaoTableAdapter.Update(EditLocacao.locacaoRow);
                    }
                    break;

            }
            this.locacaoTableAdapter.CustonQuerry(this.sistemaBibliotecaDBDataSet.Locacao);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao addLocacao = new frmAdicionarLocacao();
            addLocacao.ShowDialog();
            this.locacaoTableAdapter.CustonQuerry(this.sistemaBibliotecaDBDataSet.Locacao);
        }

    }
}
