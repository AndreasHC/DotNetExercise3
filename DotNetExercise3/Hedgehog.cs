namespace DotNetExercise3
{
    internal class Hedgehog : Animal
    {
        private int numberOfSpines;

        public int NumberOfSpines
        {
            get { return numberOfSpines; }
            set { numberOfSpines = value; }
        }

        public Hedgehog(string name, double weight, int age, int numberOfSpines) : base(name, weight, age)
        {
            NumberOfSpines = numberOfSpines;
        }

        public override void DoSound()
        {
            Console.WriteLine("squeak");
        }
    }
}
