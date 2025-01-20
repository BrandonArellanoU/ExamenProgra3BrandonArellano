using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3BrandonArellano.Repository 
{
    public class BrandonSqlite
    {
        private readonly string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "ExamP3.db3");
        private SQLiteConnection _connection;

    }

    public init()
        {
            _connection = new SQLiteConnection(_dbPath);    
        }
}
