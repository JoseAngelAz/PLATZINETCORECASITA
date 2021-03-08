using Microsoft.EntityFrameworkCore;
namespace aspnetcore_platzi.Models
{
    public class EscuelaContext : DbCotext
    {
        public DbSet <Escuela> Escuelas{ get; set; }
        public DbSet <Asignatura> Asignaturas{ get; set; }
        public DbSet <Curso> Cursos { get; set; }
        public DbSet <Evaluación> Evaluaciones{ get; set; }
        public DbSet <Alumno> Alumnos{ get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options){

        }
    }
}