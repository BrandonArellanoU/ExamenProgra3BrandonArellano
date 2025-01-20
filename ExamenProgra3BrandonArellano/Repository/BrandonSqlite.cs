using SQLite;
using static ExamenProgra3BrandonArellano.Models.BrandonModel;

namespace ExamenProgra3BrandonArellano.Repository
{
    public class BrandonSqlite
    {
        private readonly SQLiteAsyncConnection _database;

        public BrandonSqlite()
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "ExamP3.db3");
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<Country>().Wait();
        }

        public Task<int> Guardar(Country country)
        {
            return _database.InsertAsync(country);
        }

        public Task<List<Country>> ListarPaises()
        {
            return _database.Table<Country>().ToListAsync();
        }
    }
}
