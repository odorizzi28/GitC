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
    public partial class frmAdicionarUsuarios : Form
    {
        public frmAdicionarUsuarios()
        {
            InitializeComponent();
        }
        public Usuario usuario;
        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;
        private void Adicionar_Click(object sender, EventArgs e)
        {
            usuario = new Usuario
            {
                Nome = tbxNome.Text,
                Login = tbxLogin.Text,
                Senha = tbxSenha.Text,
                Email = txbEmail.Text,
                Ativo = true,
                UsuInc = 1,
                UsuAlt = 1,
                DatInc = DateTime.Now,
                DatAlt = DateTime.Now,

            };
            this.Close();
        }
    }
}
