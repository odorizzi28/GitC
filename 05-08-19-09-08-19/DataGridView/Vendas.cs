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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.

            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           var vendas = ((System.Data.DataRowView)
           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
           as DataGridView.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendas.Id);

                    }
                    break;
               case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(querysInnerJoinDataSet1.Vendas);
                        
                    }
                    break;
            }

            this.vendasTableAdapter.CustomQuerry(querysInnerJoinDataSet1.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas frmVenda = new frmAdicionarVendas();
            frmVenda.ShowDialog();

           /* this.vendasTableAdapter.Insert(
                  frmVenda.venda.Carro,
                  frmVenda.venda.Quantidade,
                  frmVenda.venda.Valor,
                  frmVenda.venda.Ativo,
                  1,
                  1,
                  frmVenda.venda.DatInc,
                  frmVenda.venda.DatAlt
                  );
                  */
        }
    }
}
