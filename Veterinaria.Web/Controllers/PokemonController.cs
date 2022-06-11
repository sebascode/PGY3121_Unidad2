using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Web.Servicio;
using Pokedex.Web.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace Pokedex.Web.Controllers
{
    public class PokemonController : Controller
    {
        IConfiguration config;
        PokemonServicio app;

        public PokemonController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("dbPokemon");
            app = new PokemonServicio(ConnectionString);
        }

        public IActionResult Index()
        {
            IList<Pokemon> lista = app.GetAll();

            return View("Listar", lista);
        }

        public IActionResult Ficha(int id)
        {
            Pokemon obj = app.Get(id);

            return View(obj);
        }

        public IActionResult Filtrar(string id)
        {
            IList<Pokemon> pokemons = app.FiltrarPorTipo(id);

            return View(pokemons);
        }
    }
}