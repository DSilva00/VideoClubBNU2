using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VideoClub.Models
{
    public class Award
    {

        int AwardID { get; set; }

        [Required]
        [StringLength(30)]
        string AwardName { get; set; }

        [Required]
        int AwardYear { get; set; }

        //Naviagation

        public virtual Movie Movie { get; set; }


    }
}
