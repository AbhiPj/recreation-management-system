using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _19030690_Abhinav_Parajuli
{
    public class TicketData
    {
        [Required]
        public string name { get; set; }
       
        public int age { get; set; }
        public int id { get; set; }

        public string time_duration { get; set; }

        public string checkinTime {get; set;}

        public string checkoutTime { get; set; }

        public string Date { get; set; }

        public string category { get; set; }

        public int price { get; set; }
    }
}
