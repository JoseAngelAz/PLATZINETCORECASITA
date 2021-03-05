using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using aspnetcore_platzi.Models;
namespace aspnetcore_platzi.Controllers
{
    public class AlumnoController : Controller  
    {
        public IActionResult Index(){
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
            var listaAlumno = new List <Alumno>{
            new Alumno{
                Nombre = "María Ester Luna Rivera",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Pastelera"
            },
            new Alumno{
                Nombre = "José Angel Azucena Méndez",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Programador"
            },
            new Alumno{
                Nombre = "Oscar Anselmo Azucena Méndez",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Técnico Reparador"
            }
            };
            ViewBag.FAcatual = DateTime.Now;
            ViewBag.Materia = "Materias";
            ViewBag.Horario = "Horario";
            //          Vista       , metodo
            //en caso de  pasarlo sin forma default
            return View("MultiAlumno",listaAlumno);

        }
    }
}