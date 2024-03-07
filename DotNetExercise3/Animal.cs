namespace DotNetExercise3
{
    internal abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        protected Animal(string name, double weight, int age) 
        {
            Name = name;
            Weight = weight;
            Age = age;

        }

        public abstract void DoSound();


    }
}
