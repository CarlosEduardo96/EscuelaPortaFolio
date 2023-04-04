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
    public partial class IndexAlumno : UserControl
    {
        private int IdEntidad;
        public IndexAlumno()
        {
            InitializeComponent();
            CargarListaAlumnos();
        }

        private void CargarListaAlumnos(){
            try {
                
                AlumnoRN alumnoRN = new AlumnoRN();
                RecargaTabla( alumnoRN.DameAlumnos());
            }
            catch (ExcepcionEscuela exEs) {
                MessageBox.Show(exEs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecargaTabla(List<AlumnoBT> lstAlumno) {
            this.lstAlumnoData.Rows.Clear();
            if (lstAlumno != null)
            {
                for (int i = 0; i < lstAlumno.Count; i++)
                {
                    lstAlumnoData.Rows.Add(lstAlumno[i].Id, lstAlumno[i].Estado, lstAlumno[i].Matricula, lstAlumno[i].NombreCompleto, lstAlumno[i].Edad, lstAlumno[i].SexoCompleto);
                    if (lstAlumno[i].Estado == 'B')
                        lstAlumnoData.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void lstAlumnoData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = lstAlumnoData.Rows[e.RowIndex];
            if (row != null) {
              
                lstAlumnoData.Enabled = false;
                pMensajeOpcion.Visible = true;

                if (row.Cells["Estado"].Value.ToString() == "A")
                {
                    this.btnEliminar.Text = "Baja";
                    this.btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
                }

                else {
                    this.btnEliminar.Text = "Alta";
                    this.btnEliminar.BackColor = Color.FromArgb(39, 174, 96);
                }
                IdEntidad = int.Parse(row.Cells["Id"].Value.ToString());
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            lstAlumnoData.Enabled = true;
            pMensajeOpcion.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                AlumnoRN alumnoRN = new AlumnoRN();
                var item = alumnoRN.BuscarPorId(IdEntidad);

                if (item == null)
                    throw new ExcepcionEscuela("El registro ya no esta disponible");

                if (item.Estado == 'A')
                    alumnoRN.Baja(IdEntidad);
                else
                    alumnoRN.Alta(IdEntidad);

            }
            catch (ExcepcionEscuela exEs)
            {
                MessageBox.Show(exEs.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                this.pMensajeOpcion.Visible = false;
                lstAlumnoData.Enabled = true;
                CargarListaAlumnos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try {
                AlumnoRN alumnoRN = new AlumnoRN();
                var item = alumnoRN.BuscarPorId(IdEntidad);
                RutaApp.ACAlumno(item, Accion.Editar);
            }
            catch (ExcepcionEscuela exEs) {
                MessageBox.Show(exEs.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPorQuery();
        }

        private void BuscarPorQuery() {
            try
            {
                
                AlumnoRN alumnoRN = new AlumnoRN();
                RecargaTabla(alumnoRN.BuscarCajaBusqueda(this.txtBuscar.Text));
            }
            catch (ExcepcionEscuela exEs)
            {
                MessageBox.Show(exEs.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
