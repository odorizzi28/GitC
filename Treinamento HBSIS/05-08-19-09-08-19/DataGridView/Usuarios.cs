using DataGridView.Adicionar;
using DataGridView.Edicao;
using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet11.Usuarios' table. You can move, or remove it, as needed.
             this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet11.Usuarios);
             //TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UserUsuarios = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;

              switch (e.ColumnIndex)
            {
                case 0: {
                        this.usuariosTableAdapter.DeleteQuery(UserUsuarios.Id);
                       
                        }break;
                case 1: {
                       // frmEdicaoUsuario editUsuario = new frmEdicaoUsuario();
                       /// editUsuario.UsuariosRow = UserUsuarios;
                      //  editUsuario.ShowDialog();
                      //  this.usuariosTableAdapter.Update(editUsuario.UsuariosRow);

                        } break;
            }

            this.usuariosTableAdapter.CustomQuerry(querysInnerJoinDataSet1.Usuarios);



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuarios formAddUsuario = new frmAdicionarUsuarios();
            formAddUsuario.ShowDialog();

           /* this.usuariosTableAdapter.Insert(
                formAddUsuario.Usu.Usuarios,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.usuariosTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Usuarios);*/
        }
    }
}
