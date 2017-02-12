using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class onlineconsultation
    {
        public int IDappointement { get; set; }
        public string dateApp { get; set; }
        public string doctorNAmeapp { get; set; }
        public string patientNAmeApp { get; set; }
    }
}
