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
    public partial class frmEdicaoEditoras : Form
    {
        public frmEdicaoEditoras()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.EditorasRow EditorasRow;
        public Editora editor;

        private void Button1_Click(object sender, EventArgs e)
        {
            EditorasRow.Nome = tbxNome.Text;
            EditorasRow.Descricao = tbxDescricao.Text;
            this.Close();
        }
    }
}
