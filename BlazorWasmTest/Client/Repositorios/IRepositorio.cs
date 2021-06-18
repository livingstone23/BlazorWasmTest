using BlazorWasmTest.Shared.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTest.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Movie> ObtenerPeliculas(); 
    }
}
