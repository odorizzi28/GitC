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
    public partial class frmEdicaoUsuarios : Form
    {
        public frmEdicaoUsuarios()
        {
            InitializeComponent();
        }
        public Usuario usuario;
        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            UsuariosRow.Nome = tbxNome.Text;
            UsuariosRow.Login = tbxLogin.Text;
            UsuariosRow.Email = txbEmail.Text;
            UsuariosRow.Senha = tbxSenha.Text;
            UsuariosRow.Ativo = true;
            UsuariosRow.UsuInt = 1;
            UsuariosRow.UsuAlt = 1;
            UsuariosRow.DatInc = DateTime.Now;
            UsuariosRow.DatAlt = DateTime.Now;
            this.Close();
        }
    }
}
