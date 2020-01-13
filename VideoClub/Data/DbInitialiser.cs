using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;
using static VideoClub.Models.Payment;

namespace VideoClub.Data
{
    public static class DbInitialiser
    {
        public static void Intialise(ApplicationDbContext context)
        {
            //InitialisePeople(context);
            //InitialiseAddresses(context);
            //IntialisePayments(context);
        }
        
        private static void IntialisePayments(ApplicationDbContext context)
        {

            // Look for any payments.
            if (context.Payments.Any())
            {
                return;   // DB has been seeded
            }

            var payment = new Payment[]
            {

                new Payment{PaymentId = 1, CardNumber=4444489835069569, CardType= CardTypes.Visa, CardName = "David", Cvv = 652},
                new Payment{PaymentId = 2, CardNumber=4969751981328080, CardType= CardTypes.Visa, CardName = "Carson", Cvv = 501},
                new Payment{PaymentId = 3, CardNumber=4865667351929825, CardType= CardTypes.Visa, CardName = "Meredith", Cvv = 127},
                new Payment{PaymentId = 4, CardNumber=4145383273974939, CardType= CardTypes.Visa, CardName = "Arturo", Cvv = 770,},
                new Payment{PaymentId = 5, CardNumber=4129285424638604, CardType= CardTypes.Visa, CardName = "Gytis", Cvv = 421,},
                new Payment{PaymentId = 6, CardNumber=4479117920009855, CardType= CardTypes.Visa, CardName = "Rafa", Cvv = 411,},
                new Payment{PaymentId = 7, CardNumber=4499314532671547, CardType= CardTypes.Visa, CardName = "John", Cvv = 760,},
                new Payment{PaymentId = 8, CardNumber=4799649552090921, CardType= CardTypes.Visa, CardName = "Diogo", Cvv = 453,},
                new Payment{PaymentId = 9, CardNumber=4332621268843145, CardType= CardTypes.Visa, CardName = "Chris", Cvv = 557,},
                new Payment{PaymentId = 10, CardNumber=4276860667986281, CardType= CardTypes.Visa, CardName = "April", Cvv = 257,}


            };

            foreach (Payment payments in payment)
            {
                context.Payments.Add(payments);
            }

            context.SaveChanges();


        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            // Look for any people.
            if (context.Addresses.Any())
            {
                return;   // DB has been seeded
            }

            var address = new Address[]
            {
                new Address{PersonID = 1, UserID="1", PersonType= PersonTypes.Admin, FirstName = "David", LastName = "Smith", Gender= Genders.Male, AddressID = 1,PaymentCardID=1},
                new Address{PersonId = 2, UserID = "2", PersonType = PersonTypes.Customer, FirstName = "Carson", LastName = "Alexander", Gender = Genders.Male, AddressID = 3, PaymentCardID = 2 },
                new Address{PersonId = 3, UserID="3", PersonType= PersonTypes.Customer, FirstName = "Meredith", LastName = "Alonso", Gender= Genders.Male, AddressID = 23,PaymentCardID=3},
                new Address{PersonId = 4, UserID="4", PersonType= PersonTypes.Customer, FirstName = "Arturo", LastName = "Roman", Gender= Genders.Male, AddressID = 2,PaymentCardID=4},
                new Address{PersonId = 5, UserID="5", PersonType= PersonTypes.Customer, FirstName = "Gytis", LastName = "Li", Gender= Genders.Male, AddressID = 4,PaymentCardID=5},
                new Address{PersonId = 6, UserID="6", PersonType= PersonTypes.Customer, FirstName = "Rafa", LastName = "Bruno", Gender= Genders.Male, AddressID = 5,PaymentCardID=61},
                new Address{PersonId = 7, UserID="7", PersonType= PersonTypes.Customer, FirstName = "John", LastName = "Butora", Gender= Genders.Male, AddressID = 6,PaymentCardID=6},
                new Address{PersonId = 8, UserID="8", PersonType= PersonTypes.Creator, FirstName = "Diogo", LastName = "Silva", Gender= Genders.Male, AddressID = 8,PaymentCardID=7},
                new Address{PersonId = 9, UserID="9", PersonType= PersonTypes.Actor, FirstName = "Chris", LastName = "Chorico", Gender= Genders.Male, AddressID = 9,PaymentCardID=18},
                new Address{PersonId = 10, UserID="10", PersonType= PersonTypes.Director, FirstName = "April", LastName = "Smith", Gender= Genders.Female, AddressID = 19,PaymentCardID=19}


            };

            foreach (Address addresses in address)
            {
                context.Addresses.Add(addresses);
            }

            context.SaveChanges();

        }

        private static void InitialisePeople(ApplicationDbContext context)
        {
            // Look for any people.
            if (context.Person.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
                new Person{PersonId = 1, UserID="1", PersonType= PersonTypes.Admin, FirstName = "David", LastName = "Smith", Gender= Genders.Male, AddressID = 1,PaymentCardID=1},
                new Person{PersonId = 2, UserID = "2", PersonType = PersonTypes.Customer, FirstName = "Carson", LastName = "Alexander", Gender = Genders.Male, AddressID = 3, PaymentCardID = 2 },
                new Person{PersonId = 3, UserID="3", PersonType= PersonTypes.Customer, FirstName = "Meredith", LastName = "Alonso", Gender= Genders.Male, AddressID = 23,PaymentCardID=3},
                new Person{PersonId = 4, UserID="4", PersonType= PersonTypes.Customer, FirstName = "Arturo", LastName = "Roman", Gender= Genders.Male, AddressID = 2,PaymentCardID=4},
                new Person{PersonId = 5, UserID="5", PersonType= PersonTypes.Customer, FirstName = "Gytis", LastName = "Li", Gender= Genders.Male, AddressID = 4,PaymentCardID=5},
                new Person{PersonId = 6, UserID="6", PersonType= PersonTypes.Customer, FirstName = "Rafa", LastName = "Bruno", Gender= Genders.Male, AddressID = 5,PaymentCardID=61},
                new Person{PersonId = 7, UserID="7", PersonType= PersonTypes.Customer, FirstName = "John", LastName = "Butora", Gender= Genders.Male, AddressID = 6,PaymentCardID=6},
                new Person{PersonId = 8, UserID="8", PersonType= PersonTypes.Creator, FirstName = "Diogo", LastName = "Silva", Gender= Genders.Male, AddressID = 8,PaymentCardID=7},
                new Person{PersonId = 9, UserID="9", PersonType= PersonTypes.Actor, FirstName = "Chris", LastName = "Chorico", Gender= Genders.Male, AddressID = 9,PaymentCardID=18},
                new Person{PersonId = 10, UserID="10", PersonType= PersonTypes.Director, FirstName = "April", LastName = "Smith", Gender= Genders.Female, AddressID = 19,PaymentCardID=19}


            };

            foreach (Person person in people)
            {
                context.Person.Add(person);
            }

            context.SaveChanges();
       }
    }
}
