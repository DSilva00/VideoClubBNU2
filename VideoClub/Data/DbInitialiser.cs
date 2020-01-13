using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;

namespace VideoClub.Data
{
    public static class DbInitialiser
    {
        public static void Intialise(ApplicationDbContext context)
        {
            //InitialisePeople(context);
            //InitialiseAddresses(context);
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            
        }

        private static void InitialisePeople(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Person.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
                new Person
                {
                    PersonId = 1,
                    AddressID = 1,

                }
            };

            foreach (Person person in people)
            {
                context.Person.Add(person);
            }

            context.SaveChanges();
       }
    }
}
