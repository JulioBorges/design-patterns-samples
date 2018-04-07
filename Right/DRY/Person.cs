using System;

namespace QualitiOfCode.Right.DRY
{
    public class Person
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public Person(string name, int age, DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            DateOfBirth = dateOfBirth;
        }
    }
}
