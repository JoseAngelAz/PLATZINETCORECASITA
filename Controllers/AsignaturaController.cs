using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using aspnetcore_platzi.Models;
namespace aspnetcore_platzi.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index(){

            return View(
                new Asignatura{
                Nombre = "Programacion Orientada a Objetos",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Enseña el paradigma de POO"
            }
            );
        }

        public IActionResult MultiAsignatura(){
            var listaAsignatura = new List <Asignatura>{
            new Asignatura{
                Nombre = "Programacion Funcional",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Enseña el paradiga de PF"
            },
            new Asignatura{
                Nombre = "Programacion Orientada a Objetos",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Enseña el paradigma de POO"
            },
            new Asignatura{
                Nombre = "Programacion Estructurada",
                UniqueId = Guid.NewGuid().ToString(),
                Descripción = "Enseña el paradigma de PE"
            }
            };
            ViewBag.Recursos = "Recursos";
            ViewBag.Profesores = "Profesores";
            ViewBag.FechaAcatual = DateTime.Now;
            return View("MultiAsignatura",listaAsignatura);
        }
    }
}