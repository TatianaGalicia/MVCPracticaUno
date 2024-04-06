using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MVCPracticaUno.Models;

namespace MVCPracticaUno.Controllers
{
    public class EquiposController : Controller
    {
        private readonly equiposDbContext _equiposDbContext;
        
            public EquiposController(equiposDbContext equiposDbContext)
              { 
               _equiposDbContext = equiposDbContext;
              }
        public IActionResult Index()
        {
            var listaDeMarcas =(from m in _equiposDbContext.marcas 
                                select m).ToList();
            ViewData["listadoDeMarcas"]= new SelectList(listaDeMarcas "Id_marcas", "nombre_marca");

            var listadoDeEquipos = (from e in _equiposDbContext.equipos 
                                    join m in _equiposDbContext.marcas on e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre= e.nombre,
                                        descrpcion = e.descrpcion,
                                        marca_id= e.marca_id,
                                        marca_nombre = m.nombre_marca,
                                    }).ToList();
            ViewData["listadoEquipo"]= listadoDeEquipos;
            return View();
        }

    }
}
