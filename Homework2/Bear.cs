namespace Homework2
{
    internal class Bear : Animal
    {
        public Bear()
        {
        }
        public Bear(string name) : base(name)
        {
            this.Name = "Bear ";
        }

        public override string ToString()
        {
            return "Bear is inherited from " + base.ToString();
        }
    }
}