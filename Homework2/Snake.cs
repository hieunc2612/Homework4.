namespace Homework2
{
    internal class Snake : Animal
    {
        public Snake()
        {
        }
        public Snake(string name) : base(name)
        {
            this.Name = "Snake ";
        }

        public override string ToString()
        {
            return "Snake is inherited from" + base.ToString();
        }
    }
}