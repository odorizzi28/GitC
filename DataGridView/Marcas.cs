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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void From2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Marcas);


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carMarcas = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;

          //  this.marcasTableAdapter.DeleteQuery(carMarcas.Id);
          //  this.marcasTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Marcas);


            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(carMarcas.Id);

                    }
                    break;
                case 1:
                    {
                        FrmEdicaoMarcas editMarcas = new FrmEdicaoMarcas();
                        editMarcas.marcasRow = carMarcas;
                        editMarcas.ShowDialog();
                        this.marcasTableAdapter.Update(editMarcas.marcasRow);

                    }
                    break;
            }   
            this.marcasTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Marcas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarcas formAddMarcas = new frmAdicionarMarcas();
            formAddMarcas.ShowDialog();

            this.marcasTableAdapter.Insert(
                formAddMarcas.marca.Nome,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.marcasTableAdapter.CustomQuerry(this.querysInnerJoinDataSet1.Marcas);
        }
    }
    }


