using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Utilidades.Excepciones;
using System.Data.SQLite;
using Utilidades.Utilidad;

namespace BD.Catalogos
{
    public class AlumnoBD : BD<AlumnoBT>
    {
        public string conexionBD;

        public AlumnoBD() { this.conexionBD = ConfigurationManager.ConnectionStrings["escuelaBD"].ConnectionString; }

        public override void Mapeo(AlumnoBT entidad, IDataRecord dataRecord)
        {
            entidad.Id = int.Parse(dataRecord["ide_Alumno"].ToString());
            entidad.Estado = char.Parse(dataRecord["est_ide"].ToString());
            entidad.Matricula =dataRecord["Matricula"].ToString();
            entidad.Nombre =dataRecord["Nombre"].ToString();
            entidad.ApPaterno =dataRecord["ApPaterno"].ToString();
            entidad.ApMaterno =dataRecord["ApMaterno"].ToString();
            entidad.Edad = int.Parse(dataRecord["Edad"].ToString());
            entidad.Sexo = char.Parse(dataRecord["Sexo"].ToString());
        }
        public void Agregar(AlumnoBT entidad) {
            SQLiteConnection con = null;
            try {
                string sql = string.Format("INSERT INTO cat_Alumno (est_ide, Matricula, Nombre, ApPaterno, ApMaterno, Edad, Sexo) VALUES('A','{0}','{1}', '{2}', '{3}',{4} , '{5}')"
                    , entidad.Matricula, entidad.Nombre, entidad.ApPaterno, entidad.ApMaterno, entidad.Edad, entidad.Sexo);

                con = new SQLiteConnection(this.conexionBD);
                con.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex) {
                throw new ExcepcionEscuela("Error al guardar los datos", ex);
            }
            finally {
                if (con != null) con.Dispose();
            }
        }
        public void Actualizar(AlumnoBT entidad) {
            SQLiteConnection con = null;
            try
            {
                string sql = $"UPDATE cat_Alumno SET Matricula= '{entidad.Matricula}', Nombre='{entidad.Nombre}', ApPaterno= '{entidad.ApPaterno}', ApMaterno= '{entidad.ApMaterno}', Edad={entidad.Edad}, Sexo='{entidad.Sexo}' WHERE ide_Alumno = {entidad.Id}";

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
        public List<AlumnoBT> Buscar(BuscarOpcion buscar, string query=null) {
            SQLiteConnection con = null;
            try {
                string sql = "SELECT * FROM cat_Alumno";

                switch (buscar) {
                    case BuscarOpcion.Todos: break;
                    case BuscarOpcion.Id: sql=sql + " WHERE ide_Alumno=" + query; break;
                    case BuscarOpcion.CajaBusqueda: 
                        sql = sql + $" WHERE Matricula LIKE '%{query}%' OR Nombre LIKE '%{query}%' OR ApPaterno LIKE '%{query}%' OR ApMaterno LIKE '%{query}%'"; break;
                    case BuscarOpcion.Opcion1: sql = sql + " WHERE Matricula='" + query+"'"; break;
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

        public void BajaAlta(int Id, EstadoRegitro Estado) {
            SQLiteConnection con = null;
            try
            {
                string sql = $"UPDATE cat_Alumno SET est_ide='{Convert.ToChar(Estado)}' WHERE ide_Alumno = {Id}";

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
