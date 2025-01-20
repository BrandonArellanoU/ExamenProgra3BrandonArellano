using SQLite;
using static ExamenProgra3BrandonArellano.Models.BrandonModel;

namespace ExamenProgra3BrandonArellano.Repository 
{
    public class BrandonSqlite
    {
        private readonly string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "ExamP3.db3");
        private SQLiteConnection _connection;

        private static string enlace = "https://restcountries.com/v3.1/name/";

        public string RespuestaApi(string pais)
            {
            string url = $"enlace"+pais;
            var cliente = new HttpClient();

            NativeName recuest = new NativeName
            {
                Country = new List<Country>
                {
                    new Country
                    {

                    }
                }
            };

            }
    }
}
