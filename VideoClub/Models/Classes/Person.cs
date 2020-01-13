using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoClub.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        public PersonTypes PersonType { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        public Genders Gender { get; set; }

        // Navigation

        public virtual Address Address { get; set; }

        public virtual Payment Payment  { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<MovieCast> MovieCasts { get; set; }
    }

    public enum PersonTypes
    {
        Admin,
        Customer,
        Creator,
        Actor,
        Director
    }

    public enum Genders
    {
        Male,
        Female
    }
}
