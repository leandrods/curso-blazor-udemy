using Microsoft.JSInterop;

namespace Peliculas.Client.Helpers
{
    public static class IJSRuntimeExtensinMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}