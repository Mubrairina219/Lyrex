using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTuerca
{
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void olvidelacontra_Click(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void textoContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formularioPrincipal = new menuPrincipal();
            formularioPrincipal.ShowDialog();

        }
    }
}
