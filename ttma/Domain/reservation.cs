using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reservation
    {
        public int id { get; set; }
        public Nullable<bool> approvation { get; set; }
        public Nullable<System.DateTime> dateReserv { get; set; }
        public Nullable<int> hotel { get; set; }
        public Nullable<int> user { get; set; }
        public virtual hotel hotel1 { get; set; }
        public virtual user user1 { get; set; }
    }
}
