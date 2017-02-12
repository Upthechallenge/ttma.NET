using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class insurance_offer
    {
        public int id_insurance { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public Nullable<int> insurer_id_user { get; set; }
        public string image { get; set; }
        public virtual staff staff { get; set; }
        public int Rating { get; set; }
        public int TotalRaters { get; set; }
        //public double AverageRating { get; set; }
    }
}
