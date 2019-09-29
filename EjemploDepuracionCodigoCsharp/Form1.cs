using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDepuracionCodigoCsharp
{
    public partial class Form1 : Form
    {
        FuncionesRelleno funcionesRelleno = new FuncionesRelleno();
        FibonacciLogica fibonacciLogica = new FibonacciLogica();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnrellenar_Click(object sender, EventArgs e)
        {
            lvnumeros.Items.Clear();
            lvvalores.Items.Clear();
            funcionesRelleno.setNumero(int.Parse(txtvalor.Text));

            foreach (int valores in funcionesRelleno.rellenar())
            {

                lvvalores.Items.Add(valores.ToString());
            }

            for (int i = 0; i < int.Parse(txtvalor.Text); i++) {

                lvnumeros.Items.Add(funcionesRelleno.rellenar()[i].ToString());
            }
           
        }

        private void btnfibonacci_Click(object sender, EventArgs e)
        {
            lvnumeros.Clear();
            lvvalores.Items.Clear();
            fibonacciLogica.setNumero(int.Parse(txtvalor.Text));

            foreach (int valores in fibonacciLogica.serieF()) {

                lvvalores.Items.Add(valores.ToString());
            }

            for(int i = 0; i < int.Parse(txtvalor.Text); i++) {

                lvnumeros.Items.Add(fibonacciLogica.serieF()[i].ToString());
            }
        }
    }
}
