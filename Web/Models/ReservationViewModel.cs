using domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Models
{
    public class ReservationViewModel
    {

        public int id { get; set; }
        public Nullable<bool> approvation { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Select date")]
        public Nullable<System.DateTime> dateReserv { get; set; }
        public Nullable<int> hotel { get; set; }
        public Nullable<int> user { get; set; }
        public virtual hotel hotel1 { get; set; }
        public virtual user user1 { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
        public IEnumerable<SelectListItem> Hotels { get; set; }
    }
}