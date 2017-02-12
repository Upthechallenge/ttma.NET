using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class operation
    {
        public int ID_offre { get; set; }
        public string date { get; set; }
        public string doctorName { get; set; }
        public string medicCenterNAme { get; set; }
        public float price_Operation { get; set; }
        public string publier { get; set; }
        public string type_Operation { get; set; }
    }
}
