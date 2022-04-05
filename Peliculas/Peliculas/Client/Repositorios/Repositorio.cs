using Peliculas.Shared.Entidades;
using System.Text;
using System.Text.Json;

namespace Peliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            string enviarJson = JsonSerializer.Serialize(enviar);
            StringContent enviarContent = new(enviarJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseHttp = await httpClient.PostAsync(url, enviarContent);

            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>{
                new Pelicula { Titulo = "Spider-Man", Lanzamiento = new DateTime(2002,7,2), Poster="https://m.media-amazon.com/images/M/MV5BMDhiODM3ZWEtZDc5ZS00NjY4LThlYzQtZTNmZjdkN2Q4YTcyXkEyXkFqcGdeQXVyMTgxOTIzNzk@._V1_QL75_UY562_CR9,0,380,562_.jpg" },
                new Pelicula { Titulo = "The Batman", Lanzamiento = new DateTime(2022,3,8), Poster="https://m.media-amazon.com/images/M/MV5BMDdmMTBiNTYtMDIzNi00NGVlLWIzMDYtZTk3MTQ3NGQxZGEwXkEyXkFqcGdeQXVyMzMwOTU5MDk@._V1_QL75_UX380_CR0,0,380,562_.jpg" },
                new Pelicula { Titulo = "Superman", Lanzamiento = new DateTime(1978,1,1), Poster="https://m.media-amazon.com/images/M/MV5BZWRjNWNmMDgtYjZiNC00NThiLWI3MzQtODkxZGRhNjJkMzNmXkEyXkFqcGdeQXVyMTYzMDM0NTU@._V1_QL75_UY562_CR18,0,380,562_.jpg" }
            };
        }
    }
}