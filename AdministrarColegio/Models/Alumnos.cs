namespace AdministrarColegio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Alumnos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        public string Identificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(10)]
        public string Edad { get; set; }

        [StringLength(50)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }
    }
}
