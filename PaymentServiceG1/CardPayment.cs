using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServiceG1
{
    public class CardPayment : Payment
    {
        public CardPayment(int orderID, DateTime date, double 
            amount, string reference, string holder, string lastFour,
            string provider) : base(orderID, date, amount, reference)
        {
            Holder = holder;
            LastFour = lastFour;
            Provider = provider;
        }
        public string Holder { get; set; }
        public string LastFour { get; set; }
        public string Provider { get; set; }


    }
}
