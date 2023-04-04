using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public abstract class BD<TEntidad> where TEntidad: new ()
    {

        public abstract void Mapeo(TEntidad entidad, IDataRecord dataRecord);

        protected List<TEntidad> ListarDatos(SQLiteCommand comando)
        {
            List<TEntidad> datos = new List<TEntidad>();
            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var Objeto = new TEntidad();
                    Mapeo(Objeto, reader);
                    datos.Add(Objeto);
                }
            }
            return datos;
        }

    }
}
