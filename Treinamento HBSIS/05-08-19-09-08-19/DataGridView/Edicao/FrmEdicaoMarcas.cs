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
    public partial class FrmEdicaoMarcas : Form
    {
        public FrmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridView.QuerysInnerJoinDataSet1.MarcasRow marcasRow;

        private void FrmEdicaoMarcas_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            marcasRow.Nome = tbxMarca.Text;
            this.Close();

        }
    }
}
