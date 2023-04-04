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
    public partial class IndexUnidad : UserControl
    {
        private int IdEntidad;

        public IndexUnidad()
        {
            InitializeComponent();
            CargarListaUnidad();
        }

        private void CargarListaUnidad()
        {
            try
            {
                UnidadRN unidadRN = new UnidadRN();
                RecargaTabla(unidadRN.DameAlumnos());
            }
            catch (ExcepcionEscuela exEs)
            {
                MessageBox.Show(exEs.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RecargaTabla(List<UnidadBT> lstUnidad)
        {
            this.lstUnidadData.Rows.Clear();
            if (lstUnidad != null)
            {
                for (int i = 0; i < lstUnidad.Count; i++)
                {
                    lstUnidadData.Rows.Add(lstUnidad[i].Id, lstUnidad[i].Estado, lstUnidad[i].Nombre, lstUnidad[i].Descripcion);
                    if (lstUnidad[i].Estado == 'B')
                        lstUnidadData.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BuscarPorQuery()
        {
            try
            {
                UnidadRN unidadRN = new UnidadRN();
                RecargaTabla(unidadRN.BuscarCajaBusqueda(this.txtBuscar.Text));
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

        private void lstUnidadData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = lstUnidadData.Rows[e.RowIndex];
            if (row != null)
            {

                lstUnidadData.Enabled = false;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                UnidadRN unidadRN = new UnidadRN();
                var item = unidadRN.BuscarPorId(IdEntidad);
                RutaApp.ACUnidad(item, Accion.Editar);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                UnidadRN unidadRN = new UnidadRN();
                var item = unidadRN.BuscarPorId(IdEntidad);

                if (item == null)
                    throw new ExcepcionEscuela("El registro ya no esta disponible");

                if (item.Estado == 'A')
                    unidadRN.Baja(IdEntidad);
                else
                    unidadRN.Alta(IdEntidad);

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
                lstUnidadData.Enabled = true;
                CargarListaUnidad();
            }
        }
    }
}
