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

namespace DataGridView.Adicionar
{
    public partial class frmAdicionarVendas : Form
    {
        public frmAdicionarVendas()
        {
            InitializeComponent();
        }

        public Venda venda;
        private void Button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox2.Text, out decimal valor);
            venda = new Venda()
            {
                Carro = textBox2.Text,
                Quantidade = numericUpDown1.DecimalPlaces,

      
            };
        }

        private void FrmAdicionarVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

        }
    }
}
