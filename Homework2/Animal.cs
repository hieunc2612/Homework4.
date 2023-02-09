namespace Homework2
{
    internal class Animal
    {

        string name;

        public string Name { get => name; set => name = value; }
        public Animal()
        {

        }
        public Animal(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "animal.";
        }
    }
}