using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VideoClub.Models
{
    public class MovieCast
    {
        public int MovieCastID { get; set; }

        [StringLength(20)]
        [Required]
        public string MovieRole { get; set; }

        //Navigation with other classes

        public Person Person { get; set; }

        public Movie Movie { get; set; }
    }
}
