namespace DotNetExercise3
{
    internal class Flamingo : Bird
    {
        private double colorSaturation;

        public double ColorSaturation
        {
            get { return colorSaturation; }
            set { colorSaturation = value; }
        }

        public Flamingo(string name, double weight, int age, double wingSpan, double colorSaturation) : base(name, weight, age, wingSpan)
        {
            ColorSaturation = colorSaturation;
        }

        public override string Stats()
        {
            return base.Stats() + $"Färgmättnad: {ColorSaturation}";
        }
    }
}
