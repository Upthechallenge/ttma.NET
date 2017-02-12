using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class problem
    {
        public problem()
        {
            this.problemdiscussions = new List<problemdiscussion>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public Nullable<bool> resolved { get; set; }
        public string title { get; set; }
        public Nullable<int> user { get; set; }
        public virtual ICollection<problemdiscussion> problemdiscussions { get; set; }
        public virtual user user1 { get; set; }
    }
}
