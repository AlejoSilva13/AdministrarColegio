namespace AdministrarColegio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_InformacionColegio
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string AñoAcademico { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string IdentificacionAlumno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string NombreAlumno { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string CodigoMateria { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string NombreMateria { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string IdentificacionProfesor { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string NombreProfesor { get; set; }

        [Key]
        [Column(Order = 7)]
        public double CalificacionFinal { get; set; }
    }
}
