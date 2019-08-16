using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridView.QuerysInnerJoinDataSet1.VendasRow vendasRows;

        private void Button1_Click(object sender, EventArgs e)
        {
           // comboBox2.Text = vendasRows.Carro;
            numericUpDown1.Value = vendasRows.Quantidade;
           // textBox2.Text = vendasRows.Valor;
        }

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

            


               
        }
    }
}
