using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect
{
    public partial class Form1 : Form 
{
        public Form1()
        {
            InitializeComponent();
        }
        // panel texto: Menu, logo ,etc
        private void PanelText_Paint(object sender, PaintEventArgs e)
        {

        }


        // segundo label bontones  museos, biblo, preguntas, etc.

        //private void PanelButtons_Paint(object sender, PaintEventArgs e)
        //{

        //}
        // butonsMuseo
        private void buttonMuseo_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "lista todos los museos.";
        }

        private void buttonBiblioteca_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "listar todas las bibliotecas.";
        }

        private void buttonProblema1_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "Problema 1: Mostrar cuantas museos hay en la zona X";
        }

        private void buttonProblema2_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "Problema 2: Mostrar en que museo y/o biblioteca trabaja el empleado X.";
        }

        private void buttonProblema3_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "Problema 3: enunciad problema 3 jsjs...";
        }

        private void buttonProblema4_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "Problema 4: enunciad problema 4 jsjs...";
        }

        private void buttonProblema5_Click(object sender, EventArgs e)
        {
            textProblemas.Text = "Problema 5: problema 5 jsjs...";
        }

        private void textTitulo_Click(object sender, EventArgs e)
        {

        }




    }

}
