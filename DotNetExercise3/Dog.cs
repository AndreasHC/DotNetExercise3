namespace DotNetExercise3
{
    internal class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("bark");
        }

        public override string Stats()
        {
            return base.Stats() + $"Ras: {Breed}\n";
        }
    }
}
