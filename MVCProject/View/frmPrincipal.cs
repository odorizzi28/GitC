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

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
          //  if (Session.user == null)
                //throw new Exception("Erro Critico de Sistema!");
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmUsuarios frmUsuario = new frmUsuarios();
            frmUsuario.ShowDialog();
        }

        private void AutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores frmautor = new frmAutores();
            frmautor.ShowDialog();

        }

        private void GênerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros frmGenero = new frmGeneros();
            frmGenero.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros frmLivro = new frmLivros();
            frmLivro.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacao frmLocacao = new frmLocacao();
            frmLocacao.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras frmEditora = new frmEditoras();
            frmEditora.ShowDialog();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
