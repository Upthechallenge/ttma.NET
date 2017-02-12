using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class HotelViewModel
    {
        

        public int id { get; set; }
        public string adresse { get; set; }
        public string description { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public  string name { get; set; }

        public  long lat { get; set; }

        public  long lon { get; set; }

        [DataType(DataType.Upload), Display(Name = "Image")]
        public byte[] pic { get; set; }

        public string PhotoString { get; set; }
        public string adressbylonlat { get; set; }

        [Display(Name = "Total rooms")]
        public Nullable<int> roomNumber { get; set; }
        public int star { get; set; }
        

    }
}