using System.Net.Http.Json;
using static ExamenProgra3BrandonArellano.Models.BrandonModel;


namespace ExamenProgra3BrandonArellano.Repository

{
    public class BrandonApi
    {

        private static readonly string BaseUrl = "https://restcountries.com/v3.1/name/";

        public async Task<Country> TenerNombre(string pais)
        {
            if (string.IsNullOrWhiteSpace(pais))
            {
                throw new ArgumentException("El nombre del país no puede estar vacío.", nameof(pais));
            }

            try
            {
                string url = $"{BaseUrl}{pais}?fields=name,region,maps";
                using var httpClient = new HttpClient();

                var paises = await httpClient.GetFromJsonAsync<List<Country>>(url);

                return paises?.FirstOrDefault();
            }
            catch 
            {
                throw;
            }
        }
    }
}



