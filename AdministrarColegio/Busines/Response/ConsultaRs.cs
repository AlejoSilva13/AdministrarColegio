using AdministrarColegio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdministrarColegio.Busines.Response
{
    public class ConsultaRs
    {
        public int IdError { get; set; }
        public string Mensaje { get; set; }
        public List<vw_InformacionColegio> Informacion { get; set; }
    }
}