using System;

namespace QualityOfCode.Wrong.DRY
{
    public class Intern
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Sector { get; private set; }
        public string Function { get; private set; }

        public Intern(string name, int age, DateTime dateOfBirth, 
            string sector, string function)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
            Sector = sector;
            Function = function;
        }
    }
}
