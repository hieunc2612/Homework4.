namespace Homework2
{
    internal class Mammal : Animal
    {
        public Mammal()
        {
        }
        public Mammal(string name) : base(name)
        {
            this.Name = "Mammal ";
        }

        public override string ToString()
        {
            return "Mammal, which is inherited from " + base.ToString();
        }
    }
}