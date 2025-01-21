using SQLite;

namespace ExamenProgra3BrandonArellano.Models
{
    public class ModeloBBDD
    {
        [PrimaryKey, AutoIncrement]
        public string? NombreOficial { get; set; }
        public string? Region { get; set; }
        public string? LinkGoogleMaps { get; set; }
        public string? Usuario { get; set; }


    }
}
