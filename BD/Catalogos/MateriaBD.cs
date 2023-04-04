using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Excepciones;
using Utilidades.Utilidad;

namespace BD.Catalogos
{
    public class MateriaBD : BD<MateriaBT>
    {

        public string conexionBD;

        public MateriaBD() { this.conexionBD = ConfigurationManager.ConnectionStrings["escuelaBD"].ConnectionString; }

        public override void Mapeo(MateriaBT entidad, IDataRecord dataRecord)
        {
            entidad.Id = int.Parse(dataRecord["ide_Materia"].ToString());
            entidad.Estado = char.Parse(dataRecord["est_ide"].ToString());
            entidad.Clave = dataRecord["Clave"].ToString();
            entidad.Nombre = dataRecord["Nombre"].ToString();

            if (dataRecord["Descripcion"] != null) { 
                entidad.Descripcion = dataRecord["Descripcion"].ToString();            
            }
        }

        public void Agregar(MateriaBT entidad)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = string.Format("INSERT INTO cat_Materia (est_ide, Clave, Nombre, Descripcion) VALUES('A','{0}','{1}', '{2}')"
                    , entidad.Clave, entidad.Nombre, entidad.Descripcion);

                con = new SQLiteConnection(this.conexionBD);
                con.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw new ExcepcionEscuela("Error al guardar los datos", ex);
            }
            finally
            {
                if (con != null) con.Dispose();
            }
        }
        public void Actualizar(MateriaBT entidad)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = $"UPDATE cat_Materia SET Clave= '{entidad.Clave}', Nombre='{entidad.Nombre}', Descripcion= '{entidad.Descripcion}' WHERE ide_Materia = {entidad.Id}";

                con = new SQLiteConnection(this.conexionBD);
                con.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw new ExcepcionEscuela("Error al guardar los datos", ex);
            }
            finally
            {
                if (con != null) con.Dispose();
            }
        }

        public List<MateriaBT> Buscar(BuscarOpcion buscar, string query = null)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = "SELECT * FROM cat_Materia";

                switch (buscar)
                {
                    case BuscarOpcion.Todos: break;
                    case BuscarOpcion.Id: sql = sql + " WHERE ide_Materia=" + query; break;
                    case BuscarOpcion.CajaBusqueda:
                        sql = sql + $" WHERE Clave LIKE '%{query}%' OR Nombre LIKE '%{query}%' OR Descripcion LIKE '%{query}%'"; break;
                    case BuscarOpcion.Opcion1: sql = sql + " WHERE Nombre='" + query + "'"; break;
                }
                con = new SQLiteConnection(this.conexionBD);
                con.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, con);
                var lista = this.ListarDatos(comando);
                con.Close();

                return lista;
            }
            catch (Exception ex)
            {
                throw new ExcepcionEscuela("Error al guardar los datos", ex);
            }
            finally
            {
                if (con != null) con.Dispose();
            }
        }

        public void BajaAlta(int Id, EstadoRegitro Estado)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = $"UPDATE cat_Materia SET est_ide='{Convert.ToChar(Estado)}' WHERE ide_Materia = {Id}";

                con = new SQLiteConnection(this.conexionBD);
                con.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                throw new ExcepcionEscuela("Error al guardar los datos", ex);
            }
            finally
            {
                if (con != null) con.Dispose();
            }
        }

    }
}
