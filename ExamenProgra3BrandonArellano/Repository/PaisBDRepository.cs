using ExamenProgra3BrandonArellano.Models;
using SQLite;
using System.Collections.ObjectModel;


namespace ExamenProgra3BrandonArellano.Repository
{
    public class PaisBDRepository
    {
        private readonly SQLiteConnection _database;

        public PaisBDRepository(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<ModeloBBDD>();
        }

        public void GuardarPais(ModeloBBDD pais)
        {
            _database.Insert(pais);
        }

        public ObservableCollection<ModeloBBDD> ObtenerPaises()
        {
            return new ObservableCollection<ModeloBBDD>(_database.Table<ModeloBBDD>().ToList());
        }

    }
}
