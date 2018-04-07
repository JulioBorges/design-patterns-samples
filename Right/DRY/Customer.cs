using System;

namespace QualitiOfCode.Right.DRY
{
    public class Customer : Person
    {
        public decimal AmountBilled { get; private set; }
        public DateTime DateOfLastPurchase { get; private set; }

        public Customer(string name, int age, DateTime dateOfBirth, decimal amountBilled, DateTime dateOfLastPurchase)
            : base(name, age, dateOfBirth)
        {
            AmountBilled = amountBilled;
            DateOfLastPurchase = dateOfLastPurchase;
        }
    }
}
