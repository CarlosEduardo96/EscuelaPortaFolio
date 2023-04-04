using BD.Encabezados;
using BT.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace RN.Encabezado
{
    public class ExamenRN
    {
        public void Guardar(ExamenBT entidad, Accion accion)
        {
            try
            {
                if (Accion.Editar == accion && entidad.Id == 0)
                    throw new ExcepcionEscuela("Error falta el id");

                if (entidad.FechaAplicacion==null)
                    throw new ExcepcionEscuela("Inserte la fecha de aplicacion");

                if (entidad.Materia==null || entidad.Materia.Id==0)
                    throw new ExcepcionEscuela("Seleccione la materia");

                if (entidad.Unidad == null || entidad.Unidad.Id == 0)
                    throw new ExcepcionEscuela("Seleccione la unidad");


                if (entidad.Estado != 'A' && Accion.Editar == accion)
                    throw new ExcepcionEscuela("No se puede editar el registro ya que esta dado de baja");

                ExamenBD alumnoBD = new ExamenBD();

                if (accion == Accion.Guardar)
                    alumnoBD.Agregar(entidad);
                else
                    alumnoBD.Actualizar(entidad);

            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ExamenBT> DameAlumnos()
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                return alumnoBD.Buscar(BuscarOpcion.Todos);
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExamenBT BuscarPorId(int Id)
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                return alumnoBD.Buscar(BuscarOpcion.Id, Id.ToString()).FirstOrDefault();
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Alta(int id)
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                alumnoBD.BajaAlta(id, EstadoRegitro.Alta);
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Baja(int id)
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                alumnoBD.BajaAlta(id, EstadoRegitro.Baja);
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ExamenBT> BuscarCajaBusqueda(string query)
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                return alumnoBD.Buscar(BuscarOpcion.CajaBusqueda, query);
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ExamenBT BuscarPorMatricula(string query)
        {
            try
            {
                ExamenBD alumnoBD = new ExamenBD();
                return alumnoBD.Buscar(BuscarOpcion.Opcion1, query).FirstOrDefault();
            }
            catch (ExcepcionEscuela exEs)
            {
                throw exEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
