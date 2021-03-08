using Microsoft.EntityFrameworkCore;
using System;

namespace aspnetcore_platzi.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet <Escuela> Escuelas{ get; set; }
        public DbSet <Asignatura> Asignaturas{ get; set; }
        public DbSet <Curso> Cursos { get; set; }
        public DbSet <Evaluación> Evaluaciones{ get; set; }
        public DbSet <Alumno> Alumnos{ get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

        }

        //sembrar datos en la db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "SalvaTech";
            escuela.Ciudad = "Soyapango";
            escuela.Pais = "Soyapango";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

        }
    }
}