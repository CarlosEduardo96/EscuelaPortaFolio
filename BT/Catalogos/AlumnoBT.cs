using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT.Catalogos
{
    public class AlumnoBT : ClaseBase
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }

        public string NombreCompleto => this.Nombre + " " + this.ApPaterno + " " + this.ApMaterno;
        public string SexoCompleto {
            get {
                if (Sexo == 'F')
                    return "FEMENINO";
                else if (Sexo == 'M')
                    return "MASCULINO";
                else
                    return "";
            }
        }
    }
}
