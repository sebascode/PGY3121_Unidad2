using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pokedex.Web.Models;
using System.Data.SqlClient;

namespace Pokedex.Web.Servicio
{
    public class PokemonServicio : IServicio<Pokemon>
    {
        private string Connection;

        public PokemonServicio(string ConnectionString)
        {
            this.Connection = ConnectionString;
        }

        public void Create(Pokemon obj)
        {
        }

        public void Delete(int id)
        {
            
        }

        public Pokemon Get(int id)
        {
            Pokemon pokemon = new Pokemon();

            using (SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();

                string query = string.Format("Select Id_Pokemon, Nombre, Altura, Peso, Tipo, Imagen, EsChainih FROM Pokemon;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            pokemon = new Pokemon()
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Altura = reader.GetInt32(2),
                                Peso = reader.GetInt32(3),
                                Tipo = reader.GetString(4),
                                Imagen = reader.GetString(5),
                                esChainih = reader.GetBoolean(6)
                            };
                        }
                    }
                }

                server.Close();
            }

            return pokemon;
        }

        public IList<Pokemon> GetAll()
        {
            IList<Pokemon> lista = new List<Pokemon>();

            using(SqlConnection server = new SqlConnection(this.Connection))
            {
                server.Open();

                string query = string.Format("Select Id_Pokemon, Nombre, Altura, Peso, Tipo, Imagen, EsChainih FROM Pokemon;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            lista.Add(new Pokemon()
                            {
                                ID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Altura = reader.GetInt32(2),
                                Peso = reader.GetInt32(3),
                                Tipo = reader.GetString(4),
                                Imagen = reader.GetString(5),
                                esChainih = reader.GetBoolean(6)
                            });
                        }
                    }
                }

                server.Close();
            }

            return lista;
        }

        public void Update(Pokemon obj)
        {

        }

        public IList<Pokemon> FiltrarPorTipo(string Tipo)
        {
            IList<Pokemon> lista = this.GetAll();

            return lista.Where(x => x.Tipo == Tipo).ToList();
        }
    }
}
