using BD.Catalogos;
using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace RN.Catalogo.Alumno
{
    public class AlumnoRN
    {
        public void Guardar(AlumnoBT entidad, Accion accion)
        {
            try
            {
                if (Accion.Editar == accion && entidad.Id == 0)
                    throw new ExcepcionEscuela("Error falta el id");

                if (string.IsNullOrEmpty(entidad.Matricula))
                    throw new ExcepcionEscuela("Inserte la matricula");

                if (string.IsNullOrEmpty(entidad.Nombre))
                    throw new ExcepcionEscuela("Inserte el nombre");


                if (string.IsNullOrEmpty(entidad.ApPaterno))
                    throw new ExcepcionEscuela("Inserte el apellido paterno");

                if (string.IsNullOrEmpty(entidad.ApMaterno))
                    throw new ExcepcionEscuela("Inserte el apellido materno");

                if (entidad.Edad < 4)
                    throw new ExcepcionEscuela("Edad no valida");

                if (entidad.Sexo != 'M' && entidad.Sexo != 'F')
                    throw new ExcepcionEscuela("Ingres un sexo valido");

                if (entidad.Estado != 'A' && Accion.Editar==accion)
                    throw new ExcepcionEscuela("No se puede editar el registro ya que esta dado de baja");

                AlumnoBD alumnoBD = new AlumnoBD();

                var item = this.BuscarPorMatricula(entidad.Matricula);

                if(item!=null && item.Id!= entidad.Id)
                    throw new ExcepcionEscuela("La matricula ya esta registrada");

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
        public List<AlumnoBT> DameAlumnos() {
            try {              
                AlumnoBD alumnoBD = new AlumnoBD();
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
        public AlumnoBT BuscarPorId(int Id)
        {
            try
            {
                AlumnoBD alumnoBD = new AlumnoBD();
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
                AlumnoBD alumnoBD = new AlumnoBD();
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
        public void Baja(int id) {
            try
            {
                AlumnoBD alumnoBD = new AlumnoBD();
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
        public List<AlumnoBT> BuscarCajaBusqueda(string query) {
            try
            {
                AlumnoBD alumnoBD = new AlumnoBD();
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
        public AlumnoBT BuscarPorMatricula(string query) {
            try
            {
                AlumnoBD alumnoBD = new AlumnoBD();
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
