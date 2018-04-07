using QualitiOfCode.Right.DRY;
using System;

namespace QualityOfCode.Right.DRY
{
    public class Employee : Person
    {
        public string Sector { get; private set; }
        public string Function { get; private set; }
        public decimal Salary { get; private set; }

        public Employee(string name, int age, DateTime dateOfBirth, 
            string sector, string function) : base(name, age, dateOfBirth)
        {
            Sector = sector;
            Function = function;
        }
    }
}
