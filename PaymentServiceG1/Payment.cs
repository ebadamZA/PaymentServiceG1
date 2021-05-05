using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServiceG1
{
    public abstract class Payment
    {
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string Reference { get; set; }

        public Payment(int orderID, DateTime date, 
            double amount, string reference)
        {
            OrderID = orderID;
            Date = date;
            Amount = amount;
            Reference = reference;
        }
    }
}
