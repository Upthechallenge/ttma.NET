using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class staff
    {
        public int id { get; set; }
        public string cin { get; set; }
        public Nullable<System.DateTime> dns { get; set; }
        public string e_mail { get; set; }
        public string function { get; set; }
        public string login { get; set; }
        public string mdp { get; set; }
        public string name { get; set; }
        public float salaire { get; set; }
        public string surname { get; set; }
    }
}
