namespace DotNetExercise3
{
    internal class Worm : Animal
    {
        private bool isPoisonous;

        public bool IsPoisonous
        {
            get { return isPoisonous; }
            set { isPoisonous = value; }
        }

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("\"There's a new sound\" by Tony Burrello");
        }
    }
}
