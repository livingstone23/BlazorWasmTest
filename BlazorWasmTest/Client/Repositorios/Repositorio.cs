using BlazorWasmTest.Shared.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTest.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Movie> ObtenerPeliculas()
        {
            return new List<Movie>()
            {
                new Movie() {Name = "Spider Man", ReleaseDate = new DateTime(2019, 07, 014)},
                new Movie() {Name = "SuperMan", ReleaseDate = new DateTime(2015, 09, 01)},
                new Movie() {Name = "XMen", ReleaseDate = new DateTime(2020, 03, 08)},
                new Movie() {Name = "Batman", ReleaseDate = new DateTime(1989, 10, 05)}
            };
        }
    }
}
