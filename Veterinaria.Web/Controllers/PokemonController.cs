using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Web.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View("Listar");
        }
    }
}
