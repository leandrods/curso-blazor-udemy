using Microsoft.AspNetCore.Components;

namespace Peliculas.Client.Shared
{
    public partial class ListadoGenerico<T>
    {
        [Parameter]
        public RenderFragment Cargando { get; set; }

        [Parameter]
        public RenderFragment NoHayRegistros { get; set; }

        [Parameter]
        public RenderFragment<T> HayRegistros { get; set; }

        [Parameter]
        public List<T> Listado { get; set; }
    }
}