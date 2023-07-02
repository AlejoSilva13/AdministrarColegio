namespace AdministrarColegio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MateriaAlumno")]
    public partial class MateriaAlumno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string NombreMateria { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreAlumno { get; set; }

        public double NotaFinal { get; set; }

        [Required]
        [StringLength(15)]
        public string CodigoMateria { get; set; }

        [Required]
        [StringLength(15)]
        public string AñoAcademico { get; set; }

        [Required]
        [StringLength(15)]
        public string Identificacion { get; set; }
    }
}
