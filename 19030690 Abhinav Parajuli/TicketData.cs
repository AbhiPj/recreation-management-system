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
        public string Name { get; set; }
       
        public int Age { get; set; }
        public int Id { get; set; }

        public string Time_duration { get; set; }

        public string CheckinTime {get; set;}

        public string CheckoutTime { get; set; }

        public string Date { get; set; }
        public string Day { get; set; }


        public string Category { get; set; }

        public int Price { get; set; }
    }
}
