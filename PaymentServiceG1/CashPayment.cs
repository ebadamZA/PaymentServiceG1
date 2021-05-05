using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServiceG1
{
    public class CashPayment : Payment
    {
        public double Tendered { get; set; }
        public double Change { get; set; }
        public string Currency { get; set; }

        public CashPayment(int orderID, DateTime date, double amount,
            string reference, double tendered, double change,
            string currency) : base (orderID, date, amount, reference)
        {
            Tendered = tendered;
            Change = change;
            Currency = currency;
        }

    }
}
