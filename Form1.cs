using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularImc_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtNombre.Text;
            p1.Edad = int.Parse(txtEdad.Text);
            if (rbtHombre.Checked)
            {
                p1.Sexo = "Hombre";
            }
            else if (rbtMujer.Checked)
            {
                p1.Sexo = "Mujer";
            }
            p1.Peso = double.Parse(txtPeso.Text);
            p1.Altura = double.Parse(txtAltura.Text);
            MessageBox.Show(p1.ToString());
            if (p1.EsMayorDeEdad() == true)
            {
                MessageBox.Show("Es mayor de edad");
            }
            else MessageBox.Show("No es mayor de edad");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que desea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            Close();
        }
    }
}
