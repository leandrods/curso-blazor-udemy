using System.ComponentModel.DataAnnotations;

namespace Peliculas.Shared.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }

        public List<GeneroPelicula> GeneroPeliculas { get; set; }
    }
}