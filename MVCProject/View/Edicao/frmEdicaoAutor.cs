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
    public partial class frmEdicaoAutor : Form
    {
        public frmEdicaoAutor()
        {
            InitializeComponent();
        }
        public MVCProject.BaseDeDadosBibliotecaDataSet.AutoresRow autoresRow;
        public Autor autor;
        private void Button1_Click(object sender, EventArgs e)
        {
           
            
            autoresRow.Nome = tbxNome.Text;
            autoresRow.Descricao = tbxDescricao.Text;
            this.Close();
        }
        
    }
}
