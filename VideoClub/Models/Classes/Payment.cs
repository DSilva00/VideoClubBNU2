using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VideoClub.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public long CardNumber { get; set; }

        [Required]
        public CardTypes CardType { get; set; }

        [Required]
        public string CardName { get; set; }

        public int Cvv { get; set; }

        public int ExperingMonth { get; set; }

        public int ExperingDay { get; set; }

        //Navigation
      // public virtual Person Person 
            // É preciso acabar esta parte (Fabio/Rafa)
            //Fazer a relação com a classe Person 

        //Tentei dar run no programa para ver se compila, e digam alguma coisa sff

        public enum CardTypes
        {
            MasterCard,
            Visa,
            AmericanExpress
        }

    }
}
