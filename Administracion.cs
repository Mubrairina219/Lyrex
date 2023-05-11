using System;
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
            if (txtContraseña.Text == "contraseña")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");

            }
        }

        private void regresarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formularioPrincipal = new menuPrincipal();
            formularioPrincipal.ShowDialog();

        }

        private void textoContraseña_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
