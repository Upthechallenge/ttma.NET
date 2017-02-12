using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class hotel
    {
        public hotel()
        {
            this.reservations = new List<reservation>();
        }

        public int id { get; set; }
        public string adresse { get; set; }
        public string description { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string name { get; set; }
        public byte[] pic { get; set; }
        public Nullable<int> roomNumber { get; set; }
        public int star { get; set; }
        public virtual ICollection<reservation> reservations { get; set; }
    }
}
