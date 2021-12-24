using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19030690_Abhinav_Parajuli
{
    public class priceData
    {
        [Required]
        public string category { get; set; }
        [Integer]
        public int rate1 { get; set; }
        [Integer]
        public int rate2 { get; set; }
        [Integer]
        public int rate3 { get; set; }
        [Integer]
        public int rate4 { get; set; }

    }
}
