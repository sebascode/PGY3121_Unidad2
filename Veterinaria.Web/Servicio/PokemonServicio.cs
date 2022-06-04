using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Web.Models;

namespace Pokedex.Web.Servicio
{
    public class PokemonServicio : IServicio<Pokemon>
    {
        IList<Pokemon> list = new List<Pokemon>();

        public PokemonServicio()
        {
            list = new List<Pokemon>
            {
                new Pokemon
                {
                    ID = 1,
                    Nombre = "Pikachu",
                    Altura = 60,
                    Peso = 5,
                    Tipo = "Eléctrico",
                    esChainih = false,
                    Imagen = "https://static.wikia.nocookie.net/espokemon/images/7/77/Pikachu.png"
                },
                new Pokemon
                {
                    ID = 2,
                    Nombre = "Bullbasaur",
                    Altura = 30,
                    Peso = 7,
                    Tipo = "Planta",
                    esChainih = false,
                    Imagen = "https://static.wikia.nocookie.net/videojuego/images/4/43/Bulbasaur.png"
                },
                new Pokemon
                {
                    ID = 3,
                    Nombre = "Rayquaza",
                    Altura = 160,
                    Peso = 200,
                    Tipo = "Dragon/Volador",
                    esChainih = false,
                    Imagen = "https://static.wikia.nocookie.net/espokemon/images/6/66/Rayquaza.png"
                },
                new Pokemon
                {
                    ID = 4,
                    Nombre = "Mew",
                    Altura = 30,
                    Peso = 2,
                    Tipo = "Psíquico",
                    esChainih = false,
                    Imagen = "https://images.wikidexcdn.net/mwuploads/wikidex/thumb/b/b4/latest/20191101221107/EP1090_Mew.png/1200px-EP1090_Mew.png"
                },
                new Pokemon
                {
                    ID = 5,
                    Nombre = "Mewtwo Con Armadura",
                    Altura = 200,
                    Peso = 90,
                    Tipo = "Psíquico",
                    esChainih = false,
                    Imagen = "https://static.wikia.nocookie.net/pokemonreloaded/images/4/4e/MewtwoArmadura.png"
                },
            };
        }

        public void Create(Pokemon obj)
        {
            list.Add(obj);
        }

        public void Delete(int id)
        {
            Pokemon obj = list.FirstOrDefault(x => x.ID == id);
            if (obj != null)
            {
                list.Remove(obj);
            }
        }

        public Pokemon Get(int id)
        {
            Pokemon obj = list.FirstOrDefault(x => x.ID == id);
            return obj;
        }

        public IList<Pokemon> GetAll()
        {
            return list;
        }

        public void Update(Pokemon obj)
        {
            Pokemon pokemon = list.FirstOrDefault(x => x.ID == obj.ID);

            pokemon = new Pokemon
            {
                Nombre = obj.Nombre,
                Peso = obj.Peso,
                Tipo = obj.Tipo,
                Imagen = obj.Imagen,
                Altura = obj.Altura,
                esChainih = obj.esChainih
            };
        }
    }
}
