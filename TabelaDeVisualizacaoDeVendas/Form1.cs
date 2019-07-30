using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabelaDeVisualizacaoDeVendas.Modelo;

namespace TabelaDeVisualizacaoDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Contrac> listaContracs = new List<Contrac>();
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            listaContracs.Add(new Contrac()
            {
                id = listaContracs.Count,
                Value = new Random().Next(100),
                DatInc = DateTime.Now }); ;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaContracs;
            BindList();
        }
        
        private void BindList()
        {
            var newList = new List<Contrac>();

            foreach (Contrac item in listaContracs)
                newList.Add(new Contrac()
                {
                    id = item.id,
                    Value = item.Value,
                    DatInc = item.DatInc
                });

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = newList;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var callumdId = dataGridView1.Rows[e.RowIndex].Cells[0];
                var collValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                switch (e.ColumnIndex)
                {
                    case 0:{
                            MessageBox.Show("Não é possivel ajustar a Coluno");
                           }break;

                    case 1:
                        {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                                    , "Edicão"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                listaContracs.FirstOrDefault(x =>
                                x.id == (int)callumdId.Value).Value = (int)collValue.Value;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (MessageBox.Show("Deseja realmente ajustar este valor?"
                                    , "Edicão"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var dataInformada = DateTime.Parse(collValue.Value.ToString());
                                if (dataInformada <= DateTime.Now)
                                    listaContracs.FirstOrDefault(x =>
                                    x.id == (int)callumdId.Value).DatInc = DateTime.Parse(collValue.Value.ToString());
                                else
                                    MessageBox.Show("Não foi possivel alterar o valor");
                            }

                        }
                        break;
                }

            }

            BindList();
        }
    }

}
