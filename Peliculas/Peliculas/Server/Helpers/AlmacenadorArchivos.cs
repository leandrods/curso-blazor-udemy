namespace Peliculas.Server.Helpers
{
    public class AlmacenadorArchivos : IAlmacenadorArchivos
    {
        private readonly string connectionString;

        public AlmacenadorArchivos(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("AzureStorage");
        }

        public Task<string> EditarArchivo(byte[] contenido, string extension, string nombreContenedor, string ruta)
        {
            throw new NotImplementedException();
        }

        public Task EliminarArchivo(string ruta, string nombreContenedor)
        {
            throw new NotImplementedException();
        }

        public Task<string> GuardarArchivo(byte[] contenido, string extension, string nombreContenedor)
        {
            throw new NotImplementedException();
        }
    }
}
