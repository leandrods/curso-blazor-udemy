﻿namespace Peliculas.Shared.Entidades
{
    public class GeneroPelicula
    {
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
