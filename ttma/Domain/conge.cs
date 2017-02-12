using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class conge
    {

        public conge()
        {
            this.conges = new List<conge>();
        }
        public int ID { get; set; }
        public string CIN { get; set; }
        public string dateDeb { get; set; }
        public string dateFin { get; set; }
        public string verif { get; set; }
        public virtual ICollection<conge> conges { get; set; }
        public string titre { get; set; }
    }
}
