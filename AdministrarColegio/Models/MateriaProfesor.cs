namespace AdministrarColegio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MateriaProfesor")]
    public partial class MateriaProfesor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string NombreMateria { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreProfesor { get; set; }

        [Required]
        [StringLength(15)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(15)]
        public string Identificacion { get; set; }
    }
}
