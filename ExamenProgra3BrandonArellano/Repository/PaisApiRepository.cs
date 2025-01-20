using ExamenProgra3BrandonArellano.Models;
using System.Net.Http.Json;


namespace ExamenProgra3BrandonArellano.Repository
{
    public class PaisApiRepository
    {
        private readonly HttpClient _httpClient;

        public PaisApiRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ModeloAPI> ObtenerPais(string nombre)
        {
            try
            {
                var respuesta = await _httpClient.GetFromJsonAsync<List<ModeloAPI>>($"https://restcountries.com/v3.1/name/{nombre}?fields=name,region,maps");
                return respuesta?.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el país: {ex.Message}");
            }
        }
    }
}
