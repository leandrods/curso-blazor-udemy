namespace Peliculas.Server.Helpers
{
    public interface IAlmacenadorArchivos
    {
        Task<string> GuardarArchivo(byte[] contenido, string extension, string nombreContenedor);
        Task EliminarArchivo(string ruta, string nombreContenedor);
        Task<string> EditarArchivo(byte[] contenido, string extension, string nombreContenedor, string ruta);
    }
}
