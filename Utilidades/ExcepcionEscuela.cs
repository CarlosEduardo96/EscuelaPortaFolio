using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Excepciones
{
    public class ExcepcionEscuela: Exception
    {
        public ExcepcionEscuela(string error):base(error) { }
        public ExcepcionEscuela(string error, Exception ex):base(error, ex) { }
        public override string Message => base.Message;
    }
}
