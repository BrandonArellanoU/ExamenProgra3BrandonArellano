
namespace ExamenProgra3BrandonArellano.Models
{
    public class ModeloAPI
    {
        public Name? name { get; set; }
        public string? region { get; set; }
        public Maps? maps { get; set; }
    }
    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public NativeName nativeName { get; set; }
    }
    public class NativeName
    {
        public Spa spa { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Maps
    {
        public string googleMaps { get; set; }
        public string openStreetMaps { get; set; }
    }
}
