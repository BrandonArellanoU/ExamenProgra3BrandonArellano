namespace ExamenProgra3BrandonArellano.Models
{
    public class BrandonModel
    {
        public class Name
        {
            public string common { get; set; }
            public string official { get; set; }
        }

        public class Maps
        {
            public string googleMaps { get; set; }
            public string openStreetMaps { get; set; }
        }

        public class Country
        {
            public Name name { get; set; }
            public string region { get; set; }
            public Maps maps { get; set; }
        }
    }
}
