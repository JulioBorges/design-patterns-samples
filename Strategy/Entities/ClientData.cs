namespace Strategy.Entities
{
    public class ClientData
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public ClientData(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
