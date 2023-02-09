namespace Homework2
{
    internal class Gorilla : Animal
    {
        public Gorilla()
        {
        }
        public Gorilla(string name) : base(name)
        {
            this.Name = "Gorilla ";
        }

        public override string ToString()
        {
            return "Gorilla is inherited from " + base.ToString();
        }
    }
}