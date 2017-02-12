using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class demandetransport
    {
        public int id { get; set; }
        public string decision { get; set; }
        public string destination { get; set; }
        public string email { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string moyenTransport { get; set; }
        public string name { get; set; }
        public string prenom { get; set; }
    }
}
