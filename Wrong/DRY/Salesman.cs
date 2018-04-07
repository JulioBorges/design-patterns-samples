using System;

namespace QualityOfCode.Wrong.DRY
{
    public class Salesman
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Sector { get; private set; }
        public string Function { get; private set; }
        public decimal Salary { get; private set; }
        public decimal PercentageOfCommission { get; private set; }
        public decimal SalesCommission { get; private set; }

        public Salesman(string name, int age, DateTime dateOfBirth, 
            string sector, string function, decimal percentageOfCommission, decimal salesCommission)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            Sector = sector;
            Function = function;
            PercentageOfCommission = percentageOfCommission;
            SalesCommission = salesCommission;
        }
    }
}
