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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustonQuerry(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Usuario = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(Usuario.Id);

                    }
                    break;
                case 1:
                    {
                        frmEdicaoUsuarios addUser = new frmEdicaoUsuarios();
                        addUser.UsuariosRow = Usuario;
                        addUser.ShowDialog();

                        this.usuariosTableAdapter.Update(addUser.UsuariosRow);
                    }
                    break;

            }
            this.usuariosTableAdapter.CustonQuerry(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios addUser = new frmAdicionarUsuarios();
            addUser.ShowDialog();
            this.usuariosTableAdapter.Insert(
                addUser.usuario.Nome,
                addUser.usuario.Login,
                addUser.usuario.Senha,
                addUser.usuario.Email,
                addUser.usuario.Ativo,
                addUser.usuario.UsuInc,
                addUser.usuario.UsuAlt,
                addUser.usuario.DatInc,
                addUser.usuario.DatAlt);

            this.usuariosTableAdapter.CustonQuerry(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
