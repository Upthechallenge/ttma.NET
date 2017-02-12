using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace domain.Entities
{
    public partial class staff
    {
        public staff()
        {
            this.insurance_offer = new List<insurance_offer>();

        }

        public int id { get; set; }
        public string cin { get; set; }
        public Nullable<System.DateTime> dns { get; set; }
       
        public string e_mail { get; set; }
        public string function { get; set; }
        
        public string login { get; set; }
       
        public string mdp { get; set; }
       
        public string name { get; set; }
        [Display(Name = "Insurance Agency")]
        public string insurance_agency { get; set; }
        public float salaire { get; set; }
        public string surname { get; set; }
        public virtual ICollection<insurance_offer> insurance_offer { get; set; }
        public string DTYPE { get; set; }
    }
}
