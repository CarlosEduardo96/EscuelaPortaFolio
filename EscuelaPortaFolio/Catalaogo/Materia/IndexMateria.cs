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
    public partial class IndexMateria : UserControl
    {
        private int IdEntidad;
        public IndexMateria()
        {
            InitializeComponent();
            CargarListaMateria();
        }

        private void CargarListaMateria()
        {
            try
            {
                MateriaRN materiaRN = new MateriaRN();
                RecargaTabla(materiaRN.DameAlumnos());
            }
            catch (ExcepcionEscuela exEs)
            {
                MessageBox.Show(exEs.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void RecargaTabla(List<MateriaBT> lstMateria)
        {
            this.lstMateriaData.Rows.Clear();
            if (lstMateria != null)
            {
                for (int i = 0; i < lstMateria.Count; i++)
                {
                    lstMateriaData.Rows.Add(lstMateria[i].Id, lstMateria[i].Estado, lstMateria[i].Clave, lstMateria[i].Nombre, lstMateria[i].Descripcion);

                    if (lstMateria[i].Estado == 'B')
                        lstMateriaData.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaRN alumnoRN = new MateriaRN();
                var item = alumnoRN.BuscarPorId(IdEntidad);
                RutaApp.ACMateria(item, Accion.Editar);
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

        private void lstMateriaData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = lstMateriaData.Rows[e.RowIndex];
            if (row != null)
            {

                lstMateriaData.Enabled = false;
                pMensajeOpcion.Visible = true;

                if (row.Cells["Estado"].Value.ToString() == "A")
                {
                    this.btnEliminar.Text = "Baja";
                    this.btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
                }

                else
                {
                    this.btnEliminar.Text = "Alta";
                    this.btnEliminar.BackColor = Color.FromArgb(39, 174, 96);
                }
                IdEntidad = int.Parse(row.Cells["Id"].Value.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaRN alumnoRN = new MateriaRN();
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
            finally
            {
                this.pMensajeOpcion.Visible = false;
                lstMateriaData.Enabled = true;
                CargarListaMateria();
            }
        }


        private void BuscarPorQuery()
        {
            try
            {


                MateriaRN materiaRN = new MateriaRN();
                RecargaTabla(materiaRN.BuscarCajaBusqueda(this.txtBuscar.Text));
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPorQuery();
        }
    }
}
