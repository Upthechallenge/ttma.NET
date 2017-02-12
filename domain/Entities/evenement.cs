using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class evenement
    {
        public int ID_event { get; set; }
        public Nullable<System.DateTime> date_event { get; set; }
        public byte[] image { get; set; }
        public string name_event { get; set; }
        public Nullable<int> nbr_de_places { get; set; }
        public Nullable<int> nbr_participants { get; set; }
        public string place_event { get; set; }
        public float price { get; set; }
        public string program { get; set; }
    }
}
