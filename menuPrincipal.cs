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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }
     

        private void LaTuercaPanel_Click(object sender, EventArgs e)
        {

        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formularioAdmin = new Administracion();
            formularioAdmin.ShowDialog();
            
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void envioDomicilio_Click(object sender, EventArgs e)
        {
            Form formularioDom = new envioDomicilio();
            formularioDom.ShowDialog();
        }
    }
}
