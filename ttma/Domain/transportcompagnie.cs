using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class transportcompagnie
    {
        public int companyId { get; set; }
        public string companyAdress { get; set; }
        public string companyCategory { get; set; }
        public float companyCost { get; set; }
        public string companyName { get; set; }
        public string companyResponsable { get; set; }
    }
}
