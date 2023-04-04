using BT.Catalogos;
using RN.Catalogo.Materia;
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

namespace EscuelaPortaFolio.Catalaogo.Materia
{
    public partial class ACMateria : UserControl
    {
        private MateriaBT Entidad;
        private Accion AccionM;
        public ACMateria(MateriaBT entidad, Accion accion)
        {
            InitializeComponent();
            this.Entidad = entidad;
            this.AccionM = accion;

            if (Entidad!=null && accion == Accion.Editar)
                CargarDatos();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarDatos() {
            this.txtClave.Text= Entidad.Clave;
            this.txtNombre.Text= Entidad.Nombre;
            this.txtDescripcion.Text = Entidad.Descripcion;
        }
        private void LimpiarCampos() {
            AccionM = Accion.Guardar;
            Entidad = new MateriaBT();
            this.txtClave.Clear();
            this.txtNombre.Clear();
            this.txtDescripcion.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                MateriaRN materiaRN = new MateriaRN();
                Entidad.Clave= this.txtClave.Text;
                Entidad.Nombre= this.txtNombre.Text;
                Entidad.Descripcion= this.txtDescripcion.Text;
                

                if(AccionM==Accion.Guardar)
                    materiaRN.Guardar(Entidad, AccionM);
                else
                    materiaRN.Guardar(Entidad, AccionM);

                MessageBox.Show("¡Datos Guradados correctamente!");

                LimpiarCampos();
                RutaApp.ListaMateria();
            }
            catch (ExcepcionEscuela exEs) {
                MessageBox.Show(exEs.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
