using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class medium
    {
        public long Id { get; set; }
        public string Titre { get; set; }
        public string SousTitre { get; set; }
        public string Resume { get; set; }
         public long IdAuteur { get; set; }
        public virtual conge conge { get; set; }
    }
}
