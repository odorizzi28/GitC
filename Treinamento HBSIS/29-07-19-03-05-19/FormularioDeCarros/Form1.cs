using FormularioDeCarros.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Carros> ListaCarro = new List<Carros>();
        private void Button1_Click(object sender, EventArgs e)
        {
            ListaCarro.Add(new Carros()
                {
                Modelo = 
                }
        }
    }
}
