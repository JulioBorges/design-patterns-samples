using System;

namespace QualityOfCode.Right.DRY
{
    public class Intern : Employee
    {
        public Intern(string name, int age, DateTime dateOfBirth, string sector, string function) 
            : base(name, age, dateOfBirth, sector, function)
        {
        }
    }
}
