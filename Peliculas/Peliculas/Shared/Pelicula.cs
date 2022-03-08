namespace Peliculas.Shared
{
    public class Pelicula
    {
        public string Titulo { get; set; } = "";
        public DateOnly Lanzamiento { get; set; }
        public string Poster { get; set; }

        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                else if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}