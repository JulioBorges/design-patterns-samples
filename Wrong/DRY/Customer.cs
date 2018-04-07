using System;

namespace QualityOfCode.Wrong.DRY
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public decimal AmountBilled { get; private set; }
        public DateTime DateOfLastPurchase { get; private set; }

        public Customer(string name, int age, DateTime dateOfBirth, 
            decimal amountBilled, DateTime dateOfLastPurchase)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            AmountBilled = amountBilled;
            DateOfLastPurchase = dateOfLastPurchase;
        }
    }
}
