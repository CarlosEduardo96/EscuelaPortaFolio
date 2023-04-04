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

namespace EscuelaPortaFolio.Catalaogo.Unidad
{
    public partial class VistaUnidad : UserControl
    {
        public VistaUnidad()
        {
            InitializeComponent();
        }

        private void btnListaAlumno_Click(object sender, EventArgs e)
        {
            RutaApp.ListaUnidad();
        }

        private void btnACUnidad_Click(object sender, EventArgs e)
        {
            RutaApp.ACUnidad(new UnidadBT(), Accion.Guardar);
        }
    }
}
