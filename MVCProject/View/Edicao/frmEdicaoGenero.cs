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

namespace MVCProject.View.Edicao
{
    public partial class frmEdicaoGenero : Form
    {
        public frmEdicaoGenero()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow GeneroRow;
        public Genero gereno;

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           GeneroRow.Tipo = textBox1.Text;
            GeneroRow.Descrição = textBox2.Text;
        }
    }
}
