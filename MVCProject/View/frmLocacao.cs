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
    }
}
