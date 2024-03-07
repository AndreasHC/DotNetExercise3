namespace DotNetExercise3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, string eyeColor) : base(name, weight, age, eyeColor)
        {
        }

        public void Talk()
        {
            Console.WriteLine("What do you want?");
        }
    }
}
