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

namespace EscuelaPortaFolio.Catalaogo.Materia
{
    public partial class VistaMateria : UserControl
    {
        public VistaMateria()
        {
            InitializeComponent();
        }

        private void btnListaMateria_Click(object sender, EventArgs e)
        {
            RutaApp.ListaMateria();
        }

        private void btnACMateria_Click(object sender, EventArgs e)
        {
            RutaApp.ACMateria(new MateriaBT(), Accion.Guardar);
        }
      
    }
}
