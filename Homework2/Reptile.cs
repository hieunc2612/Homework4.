namespace Homework2
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
        }
        public Reptile(string name) : base(name)
        {
            this.Name = "Reptile ";
        }

        public override string ToString()
        {
            return "Reptile, which is inherited from " + base.ToString();
        }
    }
}