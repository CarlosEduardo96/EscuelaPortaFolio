using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Utilidad;

namespace EscuelaPortaFolio.Catalaogo.Alumno
{
    public partial class VistaAlumno : UserControl
    {
        public VistaAlumno()
        {
            InitializeComponent();
        }

        private void btnACAlumno_Click(object sender, EventArgs e)
        {
            RutaApp.ACAlumno(new AlumnoBT(), Accion.Guardar);
        }

        private void btnListaAlumno_Click(object sender, EventArgs e)
        {
            RutaApp.ListaAlumno();
        }
    }
}
