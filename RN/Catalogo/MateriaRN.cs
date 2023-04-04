using BD.Catalogos;
using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace RN.Catalogo.Materia
{
    public class MateriaRN
    {
        public void Guardar(MateriaBT entidad, Accion accion)
        {
            try
            {
                if (Accion.Editar == accion && entidad.Id == 0)
                    throw new ExcepcionEscuela("Error falta el id");

                if (string.IsNullOrEmpty(entidad.Clave))
                    throw new ExcepcionEscuela("Inserte la clave");
                
                if (string.IsNullOrEmpty(entidad.Nombre))
                    throw new ExcepcionEscuela("Inserte el nombre");
            

                if (entidad.Estado != 'A' && Accion.Editar == accion)
                    throw new ExcepcionEscuela("No se puede editar el registro ya que esta dado de baja");

                MateriaBD materiaBD = new MateriaBD();

                var item = this.BuscarPorClave(entidad.Clave);

                if (item != null && item.Id != entidad.Id)
                    throw new ExcepcionEscuela("La clave de la materia ya esta registrada");

                if (accion == Accion.Guardar)
                    materiaBD.Agregar(entidad);
                else
                    materiaBD.Actualizar(entidad);
                
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

        public List<MateriaBT> DameAlumnos()
        {
            try
            {
                MateriaBD materiaBD = new MateriaBD();
                return materiaBD.Buscar(BuscarOpcion.Todos);
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
        public MateriaBT BuscarPorId(int Id)
        {
            try
            {
                MateriaBD materiaBD = new MateriaBD();
                return materiaBD.Buscar(BuscarOpcion.Id, Id.ToString()).FirstOrDefault();
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

        public MateriaBT BuscarPorClave(string Clave)
        {
            try
            {
                MateriaBD materiaBD = new MateriaBD();
                return materiaBD.Buscar(BuscarOpcion.Opcion1, Clave).FirstOrDefault();

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
                MateriaBD materiaBD = new MateriaBD();
                materiaBD.BajaAlta(id, EstadoRegitro.Alta);
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
                MateriaBD materiaBD = new MateriaBD();
                materiaBD.BajaAlta(id, EstadoRegitro.Baja);
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
        public List<MateriaBT> BuscarCajaBusqueda(string query)
        {
            try
            {
                MateriaBD materiaBD = new MateriaBD();
                return materiaBD.Buscar(BuscarOpcion.CajaBusqueda, query);
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
