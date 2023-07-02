using AdministrarColegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrarColegio.Busines.Response
{
    public class ConsultarMateriaRs
    {
        public int IdError { get; set; }
        public string Mensaje { get; set; }
        public List<Asignaturas> Asignaturas { get; set; }
    }
}