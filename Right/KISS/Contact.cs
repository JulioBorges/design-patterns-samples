using System;

namespace QualitiOfCode.Right.KISS
{
    public class Contact
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public Contact(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
