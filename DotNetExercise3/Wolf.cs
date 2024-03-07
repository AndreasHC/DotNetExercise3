using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetExercise3
{
    internal class Wolf : Animal
    {
        private string eyeColor;

        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }

        public Wolf(string name, double weight, int age, string eyeColor) : base(name, weight, age)
        {
            EyeColor = eyeColor;
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }

        public override string Stats()
        {
            return base.Stats() + $"Ögonfärg: {EyeColor}\n";
        }
    }
}
