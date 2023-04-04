using EscuelaPortaFolio.Catalaogo;
using EscuelaPortaFolio.Catalaogo.Alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaPortaFolio
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            RutaApp.CargarApp(pPrincipal);
            RutaApp.ListaAlumno();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            RutaApp.ListaAlumno();

        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            RutaApp.ListaMateria();
        }

        private void btnUnidad_Click(object sender, EventArgs e)
        {
            RutaApp.ListaUnidad();
        }
    }
}
