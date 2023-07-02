using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AdministrarColegio.Models
{
    public partial class BdAdministrarColegio : DbContext
    {
        public BdAdministrarColegio()
            : base("name=BdAdministrarColegio")
        {
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Asignaturas> Asignaturas { get; set; }
        public virtual DbSet<MateriaAlumno> MateriaAlumno { get; set; }
        public virtual DbSet<MateriaProfesor> MateriaProfesor { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<vw_InformacionColegio> vw_InformacionColegio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Edad)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Alumnos>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Asignaturas>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Asignaturas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaAlumno>()
                .Property(e => e.NombreMateria)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaAlumno>()
                .Property(e => e.NombreAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaAlumno>()
                .Property(e => e.CodigoMateria)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaAlumno>()
                .Property(e => e.AñoAcademico)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaAlumno>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaProfesor>()
                .Property(e => e.NombreMateria)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaProfesor>()
                .Property(e => e.NombreProfesor)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaProfesor>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<MateriaProfesor>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Identificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Edad)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Profesor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.AñoAcademico)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.IdentificacionAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.NombreAlumno)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.CodigoMateria)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.NombreMateria)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.IdentificacionProfesor)
                .IsUnicode(false);

            modelBuilder.Entity<vw_InformacionColegio>()
                .Property(e => e.NombreProfesor)
                .IsUnicode(false);
        }
    }
}
