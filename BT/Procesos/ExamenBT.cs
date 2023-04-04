using BT.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.Procesos
{
    public class ExamenBT : ClaseBase
    {
        public DateTime FechaAplicacion { get; set; }
        public double Calificacion { get; set; }
        public MateriaBT Materia{ get; set; }
        public UnidadBT Unidad { get; set; }
    }
}
