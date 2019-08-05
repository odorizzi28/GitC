using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           /* var result = this.usuariosTableAdapter1.LoginQuery(textBox1.Text, textBox2.Text);
            if (result != null)
            {
                Session.user = new Usuario
                {
                    id = (int)result
                };*/
            

            frmPrincipal principal = new frmPrincipal();
            principal.ShowDialog();

            }

           /* else
            {
                throw new Exception("Fuuuuuu");
            } 
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
