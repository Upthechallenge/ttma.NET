using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class user
    {
        public user()
        {
            this.problems = new List<problem>();
            this.problemdiscussions = new List<problemdiscussion>();
            this.reservations = new List<reservation>();
        }

        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public virtual ICollection<problem> problems { get; set; }
        public virtual ICollection<problemdiscussion> problemdiscussions { get; set; }
        public virtual ICollection<reservation> reservations { get; set; }
    }
}
