using DataGridView.Adicionar;
using DataGridView.Edicao;
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
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0: {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                       
                        }break;
                case 1: {
                        frmEdicaoCarros editCarros = new frmEdicaoCarros();
                        editCarros.CarrosRow = carSelect;
                        editCarros.ShowDialog();
                        //this.carrosTableAdapter.Update(editCarros.CarrosRow);
                        this.carrosTableAdapter.UpdateQuery(
                                editCarros.CarrosRow.Modelo,
                                editCarros.CarrosRow.Ano.ToString(),
                                editCarros.CarrosRow.Marca,
                                editCarros.CarrosRow.UsuAlt,
                                DateTime.Now,
                                editCarros.CarrosRow.Id);
                    } break;
            }

            this.carrosTableAdapter.CustomQuerry(querysInnerJoinDataSet1.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marcas frmMarcas = new Marcas();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Vendas frmVendas = new Vendas();
            frmVendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Usuarios frmUser = new Usuarios();
            frmUser.ShowDialog();
        }


        private void Button5_Click_1(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            this.carrosTableAdapter.Insert(
                formAdd.CarrosRow.Modelo,
                formAdd.CarrosRow.Ano,
                formAdd.CarrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.carrosTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Carros);
        }
    }
}
