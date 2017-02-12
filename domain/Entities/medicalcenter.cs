using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class medicalcenter
    {
        public int ID_Med_center { get; set; }
        public string adress_Med_center { get; set; }
        public string conventionne { get; set; }
        public string name_Med_center { get; set; }
        public string resp_Med_center { get; set; }
        public string speciality_Med_center { get; set; }
    }
}
