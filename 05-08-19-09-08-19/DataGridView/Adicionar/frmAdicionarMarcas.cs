﻿using DataGridView.Model;
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
    public partial class frmAdicionarMarcas : Form
    {

        public frmAdicionarMarcas()
        {
            InitializeComponent();
        }
        public Marca marca;

        private void Button1_Click(object sender, EventArgs e)
        {
            marca = new Marca
            {
                Nome = textBox1.Text

            };
            this.Close();

        }

        private void FrmAdicionarMarcas_Load(object sender, EventArgs e)
        {
            
        }
    }
}