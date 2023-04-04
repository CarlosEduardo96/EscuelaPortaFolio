using BT.Procesos;
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

namespace BD.Encabezados
{
    public class ExamenBD : BD<ExamenBT>
    {
        public string conexionBD;

        public ExamenBD() { this.conexionBD = ConfigurationManager.ConnectionStrings["escuelaBD"].ConnectionString; }

        public override void Mapeo(ExamenBT entidad, IDataRecord dataRecord)
        {
            entidad.Id = int.Parse(dataRecord["ide_Unidad"].ToString());
            entidad.Estado = char.Parse(dataRecord["est_ide"].ToString());
            //entidad.Nombre = dataRecord["Nombre"].ToString();
            //if (dataRecord["Descripcion"] != null)
            //{
            //    entidad.Descripcion = dataRecord["Descripcion"].ToString();
            //}
        }

        public void Agregar(ExamenBT entidad)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = string.Format("INSERT INTO enc_Examen (est_ide,FechaAplicacion, Calificacion, ide_Materia, ide_Unidad) VALUES('A','{0}','{1}', {2}, {3})"
                    , entidad.FechaAplicacion.ToString("yyyy-MM-dd"), entidad.Calificacion, entidad.Materia.Id, entidad.Unidad.Id);

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
        public void Actualizar(ExamenBT entidad)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = $"UPDATE enc_Examen SET FechaAplicacion= '{entidad.FechaAplicacion}', Calificacion='{entidad.Calificacion}', ide_Materia='{entidad.Materia.Id}', ide_Unidad='{entidad.Unidad.Id}' WHERE ide_Unidad = {entidad.Id}";

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
        public List<ExamenBT> Buscar(BuscarOpcion buscar, string query = null)
        {
            SQLiteConnection con = null;
            try
            {
                string sql = "SELECT * FROM enc_Examen";

                switch (buscar)
                {
                    case BuscarOpcion.Todos: break;
                    case BuscarOpcion.Id: sql = sql + " WHERE ide_Examen=" + query; break;
                    case BuscarOpcion.CajaBusqueda:
                        sql = sql + $""; break;
                    
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
                string sql = $"UPDATE enc_Examen SET est_ide='{Convert.ToChar(Estado)}' WHERE ide_Examen = {Id}";

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
