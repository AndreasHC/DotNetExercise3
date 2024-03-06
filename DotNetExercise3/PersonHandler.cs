
namespace DotNetExercise3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public int GetAge (Person pers)
        {
            return pers.Age;
        }

        public void SetFName(Person pers, string name) 
        {
            pers.FName = name;
        }

        public string GetFName(Person pers) 
        {
            return pers.FName;
        }

        public void SetLName(Person pers, string name) 
        {
            pers.LName = name;
        }

        public string GetLName(Person pers) 
        {
            return pers.LName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public double GetHeight(Person pers)
        {
            return pers.Height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public double GetWeight(Person pers)
        {
            return pers.Weight; 
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        {
            return new Person()
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
        }
    }
}
