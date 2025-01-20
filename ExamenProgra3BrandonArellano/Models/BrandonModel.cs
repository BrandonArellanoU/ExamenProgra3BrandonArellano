using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra3BrandonArellano.Models
{
    internal class BrandonModel
    {

        public class NativeName
        {
            public spa spa { get; set; }
        }

        public class spa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Name
        {
            public string common { get; set; }
            public string official { get; set; }
            public NativeName nativeName { get; set; }
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
