namespace DotNetExercise3
{
    internal class Horse : Animal
    {
        private double withersHeight;

        public double WithersHeight
        {
            get { return withersHeight; }
            set { withersHeight = value; }
        }

        public Horse(string name, double weight, int age, double withersHeight) : base(name, weight, age)
        {
            WithersHeight = withersHeight;          
        }

        public override void DoSound()
        {
            Console.WriteLine("neigh");
        }
    }
}
