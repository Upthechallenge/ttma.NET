using System;
using System.Collections.Generic;

namespace domain.Entities
{
    public partial class doctor
    {
        public int numCinDoc { get; set; }
        public string adressDoc { get; set; }
        public string clinic { get; set; }
        public string emailDoc { get; set; }
        public string firsNameDoc { get; set; }
        public int nbrYearsOfExp { get; set; }
        public string specialityDoc { get; set; }
    }
}
