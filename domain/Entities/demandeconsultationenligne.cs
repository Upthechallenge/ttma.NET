using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class demandeconsultationenligne
    {
        public int ID { get; set; }
        public string dateAppointement { get; set; }
        public string doctor_name { get; set; }
        public string patient_Name { get; set; }
    }
}
