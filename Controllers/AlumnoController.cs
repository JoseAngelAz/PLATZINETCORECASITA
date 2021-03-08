using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using aspnetcore_platzi.Models;
namespace aspnetcore_platzi.Controllers
{
    public class AlumnoController : Controller  
    {
        //para la vista de un solo alumno
        public IActionResult Index(){
             ViewBag.FAcatual = DateTime.Now;
            ViewBag.Materia = "Materias";
            ViewBag.Horario = "Horario";
            return View(
                //mandamos un objeto de alumno
                new Alumno{
                Nombre = "ANGEL AZUCENA",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Programador en stack MERN"
            }
            );
        }

        public IActionResult MultiAlumno(){
            var listaAlumno = GenAlumnoAzar();
            ViewBag.FAcatual = DateTime.Now;
            ViewBag.Materia = "Materias";
            ViewBag.Horario = "Horario";
            //          Vista       , metodo
            //en caso de  pasarlo sin forma default
            return View("MultiAlumno",listaAlumno);

        }
        //generar alumnos al azar
        private List<Alumno>GenAlumnoAzar(){
            string [] nombre1 = {"Mauricio","David","Cristina","Matias"};
            string [] apellidos = {"Luna","Mendez","Rivera","Azucena"};
            string [] nombre2 = {"Cristian","Gerardo","Maria","Alicia"};
            string [] descripcion = {"Dedicado","Responsabe","Diligente","Aciada"};

            var listaAlumnos =
                from n1 in nombre1
                from n2 in nombre2
                from a1 in apellidos
                from des1 in descripcion
                select new Alumno{
                Nombre = $"{n1}{n2}",
                Apellidos = $"{a1}",
                Descripción = $"{des1}"};
                //UniqueId = Guid.NewGuid().ToString()};

            return listaAlumnos.OrderBy((al)=>al.UniqueId).ToList();                               
        }
    }
}