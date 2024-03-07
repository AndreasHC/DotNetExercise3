namespace DotNetExercise3
{
    internal class Pelican : Bird
    {
        private double gularPouchCapacity;

        public double GularPouchCapacity
        {
            get { return gularPouchCapacity; }
            set { gularPouchCapacity = value; }
        }

        public Pelican(string name, double weight, int age, double wingSpan, double gularPouchCapacity) : base(name, weight, age, wingSpan)
        {
            GularPouchCapacity = gularPouchCapacity;
        }
    }
}
