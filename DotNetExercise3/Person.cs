
namespace DotNetExercise3
{
    internal class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än 0");
                }
                age = value;
            }
        }

        private string fName;
        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Förnamn är obligatoriskt.");
                }
                if(value.Length < 2)
                {
                    throw new ArgumentException("Förnamn måste vara minst två tecken");
                }
                if (value.Length > 10) 
                {
                    throw new ArgumentException("Förnamn får inte vara längre än 10 tecken.");
                }
                fName = value;
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Efternamn är obligatoriskt.");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Efternamn måste vara minst tre tecken");
                }
                if (value.Length > 15)
                {
                    throw new ArgumentException("Efternamn får inte vara längre än 15 tecken.");
                }

                lName = value;
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
