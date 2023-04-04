using BT.Catalogos;
using RN.Catalogo.Unidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace EscuelaPortaFolio.Catalaogo.Unidad
{
    public partial class ACUnidad : UserControl
    {
        private UnidadBT Entidad;
        private Accion AccionU;
        public ACUnidad(UnidadBT entidad, Accion accion)
        {
            InitializeComponent();
            this.Entidad = entidad;
            this.AccionU = accion;

            if (accion == Accion.Editar)
                CargarDatos();
        }

        private void CargarDatos() {
            this.txtNombre.Text = Entidad.Nombre;
            this.txtDescripcion.Text = Entidad.Descripcion;
        }

        private void LimpiarCampos() {
            AccionU = Accion.Guardar;
            this.Entidad = new UnidadBT();
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                Entidad.Nombre = this.txtNombre.Text;
                Entidad.Descripcion = this.txtDescripcion.Text;

                UnidadRN unidadRN = new UnidadRN();

                if(AccionU==Accion.Guardar)
                    unidadRN.Guardar(Entidad, AccionU);
                else
                    unidadRN.Guardar(Entidad, AccionU);

                MessageBox.Show("¡Guardado con exito!", "¡Correcto!");
                LimpiarCampos();
                RutaApp.ListaUnidad();
            }
            catch (ExcepcionEscuela exEs)
            {
                MessageBox.Show(exEs.Message, "Error");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
