using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class problemdiscussion
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string sender { get; set; }
        public string title { get; set; }
        public Nullable<int> problem { get; set; }
        public Nullable<int> user { get; set; }
        public virtual problem problem1 { get; set; }
        public virtual user user1 { get; set; }
    }
}
