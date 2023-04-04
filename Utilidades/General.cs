using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Utilidad
{
    public enum EstadoRegitro
    {
        Alta = 65,
        Baja = 66
    }
    public enum Accion
    {
        Guardar = 65,
        Editar = 67
    }

    public enum BuscarOpcion
    {
        Id = 1,
        CajaBusqueda = 2,
        Todos = 3,
        Opcion1 = 4
    }
}
