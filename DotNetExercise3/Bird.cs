namespace DotNetExercise3
{
    internal class Bird : Animal
    {
        private double wingSpan;

        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet");
        }

        public override string Stats()
        {
            return base.Stats() + $"Vingspann: {WingSpan}\n";
        }
    }
}
