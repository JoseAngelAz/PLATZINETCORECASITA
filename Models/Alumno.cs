using System.Collections.Generic;
namespace aspnetcore_platzi.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
        public string Apellidos { get; set; }
        public string Descripcion { get; set; }
    }
}