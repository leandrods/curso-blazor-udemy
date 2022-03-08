using Peliculas.Shared.Entidades;

namespace Peliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>{
                new Pelicula { Titulo = "Spider-Man", Lanzamiento = new DateOnly(2002,7,2), Poster="https://m.media-amazon.com/images/M/MV5BMDhiODM3ZWEtZDc5ZS00NjY4LThlYzQtZTNmZjdkN2Q4YTcyXkEyXkFqcGdeQXVyMTgxOTIzNzk@._V1_QL75_UY562_CR9,0,380,562_.jpg" },
                new Pelicula { Titulo = "The Batman", Lanzamiento = new DateOnly(2022,3,8), Poster="https://m.media-amazon.com/images/M/MV5BMDdmMTBiNTYtMDIzNi00NGVlLWIzMDYtZTk3MTQ3NGQxZGEwXkEyXkFqcGdeQXVyMzMwOTU5MDk@._V1_QL75_UX380_CR0,0,380,562_.jpg" },
                new Pelicula { Titulo = "Spiderman 3", Lanzamiento = new DateOnly(1978,1,1), Poster="https://m.media-amazon.com/images/M/MV5BZWRjNWNmMDgtYjZiNC00NThiLWI3MzQtODkxZGRhNjJkMzNmXkEyXkFqcGdeQXVyMTYzMDM0NTU@._V1_QL75_UY562_CR18,0,380,562_.jpg" }
            };
        }
    }
}