using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using aspnetcore_platzi.Models;
namespace aspnetcore_platzi.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;

        public IActionResult Index(){
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "SalvaTech";
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.CosaDos = "Jalado con ViewBag";
            ViewBag.FechaAcatual = System.DateTime.Today;
            escuela.Ciudad="Soyapango";
            escuela.Pais="Soyapango";
            escuela.TipoEscuela=TiposEscuela.Secundaria;
            var escuela = _context.Escuelas.FirstOrDefault(); 
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context){
            _context = context;
        }
    }
}