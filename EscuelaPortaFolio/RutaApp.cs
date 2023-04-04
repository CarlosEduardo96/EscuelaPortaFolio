using BT.Catalogos;
using EscuelaPortaFolio.Catalaogo.Alumno;
using EscuelaPortaFolio.Catalaogo.Materia;
using EscuelaPortaFolio.Catalaogo.Unidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Utilidad;

namespace EscuelaPortaFolio.Catalaogo
{
    public static class RutaApp
    {
        private static Panel panelPrincipal;
        public static void CargarApp(Panel panel) {
            panelPrincipal = panel;
        }
        public static void ListaAlumno() {
            panelPrincipal.Controls.Clear();
            VistaAlumno a = new VistaAlumno();
            IndexAlumno indexAlumno = new IndexAlumno();
            a.pAlumnoPrincipal.Controls.Add(indexAlumno);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }

        public static void ACAlumno(AlumnoBT alumnoBT, Accion accion)
        {
            panelPrincipal.Controls.Clear();
            VistaAlumno a = new VistaAlumno();
            ACAlumno AC = new ACAlumno(alumnoBT, accion);
            a.pAlumnoPrincipal.Controls.Add(AC);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }


        public static void ListaMateria() {
            panelPrincipal.Controls.Clear();
            VistaMateria a = new VistaMateria();
            IndexMateria indexMateria = new IndexMateria();
            a.pMateriaPrincipal.Controls.Add(indexMateria);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }

        public static void ACMateria(MateriaBT materiaBT, Accion accion)
        {
            panelPrincipal.Controls.Clear();
            VistaMateria a = new VistaMateria();
            ACMateria AC = new ACMateria(materiaBT, accion);
            a.pMateriaPrincipal.Controls.Add(AC);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }

        public static void ListaUnidad()
        {
            panelPrincipal.Controls.Clear();
            VistaUnidad a = new VistaUnidad();
            IndexUnidad indexUnidad = new IndexUnidad();
            a.pUnidadPrincipal.Controls.Add(indexUnidad);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }

        public static void ACUnidad(UnidadBT unidadBT, Accion accion)
        {
            panelPrincipal.Controls.Clear();
            VistaUnidad a = new VistaUnidad();
            ACUnidad AC = new ACUnidad(unidadBT, accion);
            a.pUnidadPrincipal.Controls.Add(AC);
            a.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(a);
        }
    }
}
