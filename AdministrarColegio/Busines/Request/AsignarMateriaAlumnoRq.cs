using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrarColegio.Busines.Request
{
    public class AsignarMateriaAlumnoRq
    {
        public string Codigo { get; set; }
        public string Identificacion { get; set; }
        public float NotaFinal { get; set; }
        public string AñoAcademico { get; set; }
    }
}