using System;
using QualityOfCode.Right.DRY;

namespace QualitiOfCode.Right.DRY
{
    public class Salesman : Employee
    {
        public decimal PercentageOfCommission { get; private set; }
        public decimal SalesCommission { get; private set; }

        public Salesman(string name, int age, DateTime dateOfBirth, 
            string sector, string function, decimal percentageOfCommission, decimal salesCommission)
            : base(name, age, dateOfBirth, sector, function)
        {
            PercentageOfCommission = percentageOfCommission;
            SalesCommission = salesCommission;
        }
    }
}
