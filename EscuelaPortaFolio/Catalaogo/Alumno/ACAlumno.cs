using BT.Catalogos;
using RN.Catalogo.Alumno;
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

namespace EscuelaPortaFolio.Catalaogo.Alumno
{
    public partial class ACAlumno : UserControl
    {
        private Accion AccionBD;
        private AlumnoBT Entidad;
        public ACAlumno(AlumnoBT entidad, Accion accion)
        {
            AccionBD = accion;
            this.Entidad = entidad;
            InitializeComponent();
            if(accion==Accion.Editar)
                CargarDatos();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (char)Keys.Back!= e.KeyChar){
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                Entidad.Matricula = txtMatricula.Text;
                Entidad.Nombre = txtNombre.Text;
                Entidad.ApPaterno = txtApPaterno.Text;
                Entidad.ApMaterno = txtApMaterno.Text;

                if (!string.IsNullOrEmpty(txtEdad.Text))
                    Entidad.Edad = int.Parse(txtEdad.Text);

                if (CBSexo.SelectedItem!=null && CBSexo.SelectedItem.ToString() != "N/A") 
                    Entidad.Sexo = char.Parse(CBSexo.SelectedItem.ToString());

                AlumnoRN alumnoRN = new AlumnoRN();
                alumnoRN.Guardar(Entidad, AccionBD);

                MessageBox.Show("¡Guardado con exito!", "¡Correcto!");
                LimpiarCampos();
                RutaApp.ListaAlumno();

            }
            catch (ExcepcionEscuela ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos() {
            AccionBD = Accion.Guardar;
            Entidad = new AlumnoBT();
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtEdad.Clear();
            CBSexo.SelectedItem=null;
        }

        private void CargarDatos() {
            txtMatricula.Text = Entidad.Matricula;
            txtNombre.Text = Entidad.Nombre;
            txtApPaterno.Text = Entidad.ApPaterno;
            txtApMaterno.Text = Entidad.ApMaterno;
            txtEdad.Text = Entidad.Edad.ToString();
            CBSexo.Text = Entidad.Sexo.ToString(); ;
        }
    }
}
