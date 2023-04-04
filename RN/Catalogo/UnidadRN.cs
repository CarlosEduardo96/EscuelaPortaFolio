using BD.Catalogos;
using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace RN.Catalogo.Unidad
{
    public class UnidadRN
    {
        public void Guardar(UnidadBT entidad, Accion accion)
        {
            try
            {
                if (Accion.Editar == accion && entidad.Id == 0)
                    throw new ExcepcionEscuela("Error falta el id");

                if (string.IsNullOrEmpty(entidad.Nombre))
                    throw new ExcepcionEscuela("Inserte el nombre");

                if (entidad.Estado != 'A' && Accion.Editar == accion)
                    throw new ExcepcionEscuela("No se puede editar el registro ya que esta dado de baja");

                UnidadBD unidadBD = new UnidadBD();

                var item = this.BuscarPorNombre(entidad.Nombre);

                if (item != null && item.Id != entidad.Id)
                    throw new ExcepcionEscuela("El nombre de la unidad ya esta registrada");

                if (accion == Accion.Guardar)
                    unidadBD.Agregar(entidad);
                else
                    unidadBD.Actualizar(entidad);

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

        public List<UnidadBT> DameAlumnos()
        {
            try
            {
                UnidadBD unidadBD = new UnidadBD();
                return unidadBD.Buscar(BuscarOpcion.Todos);
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
        public UnidadBT BuscarPorId(int Id)
        {
            try
            {
                UnidadBD unidadBD = new UnidadBD();
                return unidadBD.Buscar(BuscarOpcion.Id, Id.ToString()).FirstOrDefault();
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

        public UnidadBT BuscarPorNombre(string Nombre)
        {
            try
            {
                UnidadBD unidadBD = new UnidadBD();
                return unidadBD.Buscar(BuscarOpcion.Opcion1, Nombre).FirstOrDefault();

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
                UnidadBD unidadBD = new UnidadBD();
                unidadBD.BajaAlta(id, EstadoRegitro.Alta);
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
                UnidadBD unidadBD = new UnidadBD();
                unidadBD.BajaAlta(id, EstadoRegitro.Baja);
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
        public List<UnidadBT> BuscarCajaBusqueda(string query)
        {
            try
            {
                UnidadBD unidadBD = new UnidadBD();
                return unidadBD.Buscar(BuscarOpcion.CajaBusqueda, query);
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
